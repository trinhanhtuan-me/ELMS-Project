using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Controllers;

[Authorize(Roles = "Parent")]
public class OrderController(IPaymentService paymentService, ILocalizationService localizer) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 6)
    {
        try
        {
            var parentId = GetCurrentUserId();
            var orders = await paymentService.GetOrdersForParentAsync(parentId, pageNumber, pageSize);
            return View("~/Views/Parent/Order/Index.cshtml", orders);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", "Home");
        }
    }

    [HttpGet]
    public async Task<IActionResult> Detail(Guid id)
    {
        try
        {
            var parentId = GetCurrentUserId();
            var details = await paymentService.GetOrderDetailsAsync(parentId, id);
            return View("~/Views/Parent/Order/Detail.cshtml", details);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index");
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
