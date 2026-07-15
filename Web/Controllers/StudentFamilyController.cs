using Application.Dtos.StudentFamily;
using Application.Exceptions;
using Application.UseCases;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web.ViewModels;

namespace Web.Controllers
{
    public class StudentFamilyController(IStudentFamilyService _studentFamily, IParentLinkService _parentLink) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!Guid.TryParse(userIdString, out Guid studentId))
            {
                return Unauthorized();
            }

            var parentLink = await _studentFamily.FindParentLinkRequest(studentId);
            var viewModel = new StudentFamilyViewModel
            {
                StudentName = User.Identity?.Name ?? "Student",
                CourseRequests = new List<CourseRequestItemViewModel>()
            };

            // Gán dữ liệu trạng thái
            if (parentLink == null)
            {
                viewModel.ParentLinkStatus = "NotLinked";
            }
            else if (parentLink.Status == ParentLinkRequestStatus.Pending)
            {
                viewModel.ParentLinkStatus = "Pending";
                viewModel.ParentLinkRequestId = parentLink.Id;
                viewModel.ParentEmail = parentLink.Parent?.IdNavigation?.Email;
            }
            else if (parentLink.Status == ParentLinkRequestStatus.Approved)
            {
                viewModel.ParentLinkStatus = "Linked";
                viewModel.ParentLinkRequestId = parentLink.Id;
                viewModel.ParentEmail = parentLink.Parent?.IdNavigation?.Email;
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SendRequest([FromForm] SendParentLinkRequest requestDto)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
                Guid studentId = Guid.Parse(userIdString!);
                await _studentFamily.SendParentLink(studentId, requestDto);
                TempData["SuccessToast"] = "Request sent successfully. Please wait for parent's approval!";
                return RedirectToAction(nameof(Index));
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> CancelRequest([FromForm] CancelParentLinkRequest requestDto)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Guid studentId = Guid.Parse(userIdString!);
                await _studentFamily.CancelParentLink(studentId, requestDto);
                TempData["SuccessToast"] = "Account link request has been canceled successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Unlink([FromForm] Guid parentId, string? note)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Guid studentId = Guid.Parse(userIdString!);
                await _parentLink.UnlinkStudentAsync(parentId, studentId, note);

                TempData["SuccessToast"] = "Account unlinked successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
