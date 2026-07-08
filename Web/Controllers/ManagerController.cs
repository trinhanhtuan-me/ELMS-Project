using Application.Dtos.Manager;
using Application.Exceptions;
using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    // [Authorize(Roles = "Manager")] 
    [Route("manager")]
    public class ManagerController(IManagerDashboardService _dashboardService , IManagerCourseService _managerCourseService) : Controller
    {
        [HttpGet("dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var dashboardData = await _dashboardService.GetDashboardAsync();
            return View(dashboardData);
        }

        [HttpPost("approve")]
        public async Task<IActionResult> Approve(Guid courseId,  [FromForm] string source)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            var result = await _dashboardService.ApproveCourseAsync(courseId);
            if (result)
            {
                TempData["SuccessToast"] = "Approve Success!";
            }
            if (source == "management") return RedirectToAction(nameof(CourseManagement));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("reject")]
        public async Task<IActionResult> Reject(Guid courseId, string rejectReason, [FromForm] string source)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            var result = await _dashboardService.RejectCourseAsync(courseId, managerId, rejectReason);
            if (result)
            {
                TempData["SuccessToast"] = "Reject Success!";
            }
            if (source == "management") return RedirectToAction(nameof(CourseManagement));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("unpublish")]
        public async Task<IActionResult> Unpublish(Guid courseId)
        {
            try
            {
                await _dashboardService.UnpublishCourseAsync(courseId);
                TempData["SuccessToast"] = "UnPublish Success!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }

            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("publish")]
        public async Task<IActionResult> Publish(PublishCourseRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .FirstOrDefault();

                TempData["ErrorToast"] = errorMessage ?? "Invalid Validation";
                return RedirectToAction(nameof(Dashboard));
            }

            try
            {
                await _dashboardService.PublishCourseAsync(request.CourseId, request.PublishDate, request.Price);
                TempData["SuccessToast"] = "Publish Success!";
            }
            catch (BusinessRuleException ex)
            {
               
                TempData["ErrorToast"] = ex.Message;
            }

            return RedirectToAction(nameof(Dashboard));
        }

        [HttpGet("course-detail/{id}")]
        public async Task<IActionResult> CourseDetail(Guid id, [FromQuery] string source = "dashboard")
        {
            try
            {
                var courseDetail = await _dashboardService.GetCourseDetailAsync(id);
                ViewBag.Source = source;
                return View(courseDetail);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Dashboard));
            }
        }

        [HttpGet("course-management")]
        public IActionResult CourseManagement()
        {
            return View();
        }

        [HttpGet("api/courses")]
        public async Task<IActionResult> GetCoursesApi(
            [FromQuery] string status = "all",
            [FromQuery] string keyword = "",
            [FromQuery] int categoryId = 0,
            [FromQuery] string sort = "newest",
            [FromQuery] int page = 1,
            [FromQuery] int size = 10)
        {
            var response = await _managerCourseService.GetFilteredCoursesAsync(status, keyword, categoryId, sort, page, size);

            return Json(response);
        }

        [HttpPost("api/bulk-approve")]
        public async Task<IActionResult> BulkApprove([FromBody] List<Guid> courseIds)
        {
            if (courseIds == null || !courseIds.Any()) return BadRequest("No courses selected.");

            try
            {
                foreach (var id in courseIds)
                {
                    await _dashboardService.ApproveCourseAsync(id);
                }
                TempData["SuccessToast"] = "Approve Success!";
            }
            catch (BusinessRuleException ex) 
            {
                TempData["ErrorToast"] = ex.Message;
            }
            catch (Exception ex) 
            {
                TempData["ErrorToast"] = "Error : " + ex.Message;
            }

            return Ok();
        }

        [HttpPost("api/bulk-reject")]
        public async Task<IActionResult> BulkReject([FromBody] BulkRejectRequest request)
        {
            if (request.CourseIds == null || !request.CourseIds.Any()) return BadRequest("No courses selected.");

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            try
            {
                foreach (var id in request.CourseIds)
                {
                    await _dashboardService.RejectCourseAsync(id, managerId, request.Reason);
                }
                TempData["SuccessToast"] = "Reject Success!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error: " + ex.Message;
            }

            return Ok();
        }




    }

}
