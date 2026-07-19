using Application.Dtos.Billing;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Controllers;

[Authorize(Roles = "Parent")]
public class PaymentController(IPaymentService paymentService, ILocalizationService localizer) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        try
        {
            var parentId = GetCurrentUserId();
            var unpaidItems = await paymentService.GetUnpaidRequestsForParentAsync(parentId);
            return View("~/Views/Parent/Payment/Index.cshtml", unpaidItems);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", "Home");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Initiate(InitiatePaymentRequestDto dto)
    {
        if (!ModelState.IsValid)
        {
            var firstError = string.Join(" ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
            TempData["ErrorToast"] = firstError;
            return RedirectToAction("Index");
        }

        try
        {
            var parentId = GetCurrentUserId();
            var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "127.0.0.1";
            var returnUrl = Url.Action("Callback", "Payment", null, Request.Scheme) ?? "";

            var paymentUrl = await paymentService.CreateOrderAndInitiatePaymentAsync(parentId, dto.RequestIds, ipAddress, returnUrl);
            return Redirect(paymentUrl);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index");
        }
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Callback()
    {
        try
        {
            var vnpayParams = new Dictionary<string, string>();
            foreach (var key in Request.Query.Keys)
            {
                var value = Request.Query[key].ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    vnpayParams.Add(key, value);
                }
            }

            var isPaid = await paymentService.ProcessVNPayReturnAsync(vnpayParams);
            
            ViewBag.IsSuccess = isPaid;
            vnpayParams.TryGetValue("vnp_Amount", out var amountStr);
            vnpayParams.TryGetValue("vnp_TxnRef", out var txnRef);
            vnpayParams.TryGetValue("vnp_PayDate", out var payDateStr);

            if (decimal.TryParse(amountStr, out var amountDecimal))
            {
                ViewBag.Amount = amountDecimal / 100;
            }
            ViewBag.TxnRef = txnRef;
            
            if (!string.IsNullOrEmpty(payDateStr) && payDateStr.Length == 14)
            {
                if (DateTime.TryParseExact(payDateStr, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out var payDate))
                {
                    ViewBag.PayDate = payDate;
                }
            }
            ViewBag.PayDate ??= DateTime.Now;

            return View("~/Views/Parent/Payment/Result.cshtml");
        }
        catch (Exception ex)
        {
            ViewBag.IsSuccess = false;
            ViewBag.ErrorMessage = ex.Message;
            return View("~/Views/Parent/Payment/Result.cshtml");
        }
    }

    private Guid GetCurrentUserId()
    {
        var idClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(idClaim) || !Guid.TryParse(idClaim, out var userId))
        {
            throw new UnauthorizedAccessException("Không xác thực được người dùng.");
        }
        return userId;
    }
}
