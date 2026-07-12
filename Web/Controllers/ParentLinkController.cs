using Application.Dtos.ParentLink;
using Application.Exceptions;
using Application.Interfaces;
using Application.UseCases;
using Web.Services;
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
        public async Task<IActionResult> Approve(ApproveLinkRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return await RenderIndexViewWithErrors("Pending");
            }

            try
            {
                var parentId = GetCurrentUserId();
                await linkService.ApproveRequestAsync(parentId, dto);
                TempData["SuccessToast"] = localizer["toast_success_approve"];
                return RedirectToAction("Index", new { status = "Pending" });
            }
            catch (BusinessRuleException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return await RenderIndexViewWithErrors("Pending");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Reject(RejectLinkRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return await RenderIndexViewWithErrors("Pending");
            }

            try
            {
                var parentId = GetCurrentUserId();
                await linkService.RejectRequestAsync(parentId, dto);
                TempData["SuccessToast"] = localizer["toast_success_reject"];
                return RedirectToAction("Index", new { status = "Pending" });
            }
            catch (BusinessRuleException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return await RenderIndexViewWithErrors("Pending");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Unlink(Guid studentId, string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                ModelState.AddModelError(string.Empty, localizer["err_unlink_reason_required"]);
                return await RenderIndexViewWithErrors("Approved");
            }

            try
            {
                var parentId = GetCurrentUserId();
                await linkService.UnlinkStudentAsync(parentId, studentId, note);
                TempData["SuccessToast"] = localizer["toast_success_unlink"];
                return RedirectToAction("Index", new { status = "Approved" });
            }
            catch (BusinessRuleException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return await RenderIndexViewWithErrors("Approved");
            }
        }

        private async Task<IActionResult> RenderIndexViewWithErrors(string status)
        {
            try
            {
                var parentId = GetCurrentUserId();
                var requests = await linkService.GetRequestsForParentAsync(parentId, status, 1, 6);
                ViewBag.CurrentStatus = status;
                return View("~/Views/Parent/Link/Index.cshtml", requests);
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
}
