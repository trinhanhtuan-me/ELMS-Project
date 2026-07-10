using Application.Dtos.ParentLink;
using Application.Exceptions;
using Application.Interfaces;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentLinkController(IParentLinkService linkService, ILocalizationService localizer) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(string status = "Pending", int pageNumber = 1, int pageSize = 6)
        {
            try
            {
                var parentId = GetCurrentUserId();
                var requests = await linkService.GetRequestsForParentAsync(parentId, status, pageNumber, pageSize);
                ViewBag.CurrentStatus = status;
                return View("~/Views/Parent/Link/Index.cshtml", requests);
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Approve(Guid requestId)
        {
            try
            {
                var parentId = GetCurrentUserId();
                await linkService.ApproveRequestAsync(parentId, new ApproveLinkRequestDto { RequestId = requestId });
                TempData["SuccessToast"] = localizer["toast_success_approve"];
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { status = "Pending" });
        }

        [HttpPost]
        public async Task<IActionResult> Reject(Guid requestId, string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                TempData["ErrorToast"] = localizer["err_reject_reason_required"];
                return RedirectToAction("Index", new { status = "Pending" });
            }

            try
            {
                var parentId = GetCurrentUserId();
                await linkService.RejectRequestAsync(parentId, new RejectLinkRequestDto { RequestId = requestId, Note = note });
                TempData["SuccessToast"] = localizer["toast_success_reject"];
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { status = "Pending" });
        }

        [HttpPost]
        public async Task<IActionResult> Unlink(Guid studentId)
        {
            try
            {
                var parentId = GetCurrentUserId();
                await linkService.UnlinkStudentAsync(parentId, studentId, "Phụ huynh chủ động gỡ liên kết.");
                TempData["SuccessToast"] = localizer["toast_success_unlink"];
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { status = "Approved" });
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
}
