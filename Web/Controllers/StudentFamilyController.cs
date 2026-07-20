using Application.Dtos.CourseRequest;
using Application.Dtos.StudentFamily;
using Application.Exceptions;
using Application.UseCases;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web.ViewModels;

namespace Web.Controllers
{
    public class StudentFamilyController(IStudentFamilyService _studentFamily, IParentLinkService _parentLink, ICourseRequestService _courseRequestService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] string? keyword, [FromQuery] CourseRequestStatus? status, [FromQuery] int pageNumber = 1)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!Guid.TryParse(userIdString, out Guid studentId))
            {
                return Unauthorized();
            }

            var parentLink = await _studentFamily.FindParentLinkRequest(studentId);

            var getListRequest = new GetListCourseRequest(keyword, status, null, pageNumber, 10);
            var courseRequestsData = await _courseRequestService.GetListCourseByStudent(studentId, getListRequest);

            var viewModel = new StudentFamilyViewModel
            {
                StudentName = User.Identity?.Name ?? "Student",
                SearchKeyword = keyword,
                FilterStatus = status?.ToString(),
                CurrentPage = pageNumber,
                TotalItems = courseRequestsData.Total,
                TotalPages = (int)Math.Ceiling(courseRequestsData.Total / 10.0), // pageSize is 10
                CourseRequests = courseRequestsData.Data.Select(x => new CourseRequestItemViewModel
                {
                    CourseRequestId = x.Id,
                    CourseId = x.CourseId,
                    CourseName = x.Title,
                    Status = x.Status,
                    Note = x.Note
                }).ToList()
            };

            // Gán dữ liệu trạng thái
            if (parentLink == null || parentLink.Status == ParentLinkRequestStatus.Canceled
                || parentLink.Status == ParentLinkRequestStatus.Unlink || parentLink.Status == ParentLinkRequestStatus.Rejected)
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
                viewModel.ParentId = parentLink.ParentId;
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


        [HttpPost]
        public async Task<IActionResult> SaveCourseRequest([FromForm] SaveCourseRequest request)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var securedRequest = new SaveCourseRequest(
                    Guid.Parse(userIdString!),
                    request.CourseId
                );

                await _courseRequestService.SaveCourseRequest(securedRequest);

                TempData["SuccessToast"] = "Course request has been saved ";
                return RedirectToAction(nameof(Index));
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> SendCourseRequest([FromForm] SendCourseRequestInput request)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Guid studentId = Guid.Parse(userIdString!);

                await _courseRequestService.SendCourseRequest(studentId, request);

                TempData["SuccessToast"] = "Course request has been sent to your parent!";
                return RedirectToAction(nameof(Index));
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> CancelCourseRequest([FromForm] CancelCourseRequest request)
        {
            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Guid studentId = Guid.Parse(userIdString!);

                await _courseRequestService.CancelCourseRequest(studentId, request);

                TempData["SuccessToast"] = "Course request has been canceled successfully!";
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
