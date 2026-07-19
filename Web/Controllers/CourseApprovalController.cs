using Application.Dtos.Billing;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Services;

namespace Web.Controllers;

[Authorize(Roles = "Parent")]
public class CourseApprovalController(ICourseApprovalService approvalService, ILocalizationService localizer) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(string status = "Pending", int pageNumber = 1, int pageSize = 6)
    {
        try
        {
            var parentId = GetCurrentUserId();
            var requests = await approvalService.GetRequestsForParentAsync(parentId, status, pageNumber, pageSize);
            ViewBag.CurrentStatus = status;
            return View("~/Views/Parent/CourseApproval/Index.cshtml", requests);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", "Home");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Approve(ApproveCourseRequestDto dto)
    {
        if (!ModelState.IsValid)
        {
            return await RenderIndexViewWithErrors("Pending");
        }

        try
        {
            var parentId = GetCurrentUserId();
            await approvalService.ApproveRequestAsync(parentId, dto);
            TempData["SuccessToast"] = "Đã phê duyệt yêu cầu đăng ký khóa học thành công.";
            return RedirectToAction("Index", new { status = "Pending" });
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", new { status = "Pending" });
        }
    }

    [HttpPost]
    public async Task<IActionResult> Reject(RejectCourseRequestDto dto)
    {
        if (!ModelState.IsValid)
        {
            var firstError = string.Join(" ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
            TempData["ErrorToast"] = firstError;
            return RedirectToAction("Index", new { status = "Pending" });
        }

        try
        {
            var parentId = GetCurrentUserId();
            await approvalService.RejectRequestAsync(parentId, dto);
            TempData["SuccessToast"] = "Đã từ chối yêu cầu đăng ký khóa học.";
            return RedirectToAction("Index", new { status = "Pending" });
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", new { status = "Pending" });
        }
    }

    private async Task<IActionResult> RenderIndexViewWithErrors(string status)
    {
        try
        {
            var parentId = GetCurrentUserId();
            var requests = await approvalService.GetRequestsForParentAsync(parentId, status, 1, 6);
            ViewBag.CurrentStatus = status;
            return View("~/Views/Parent/CourseApproval/Index.cshtml", requests);
        }
        catch (Exception ex)
        {
            TempData["ErrorToast"] = ex.Message;
            return RedirectToAction("Index", "Home");
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
