using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    // [Authorize(Roles = "Manager")] 
    [Route("manager")]
    public class ManagerController(IManagerDashboardService _dashboardService) : Controller
    {
        [HttpGet("dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var dashboardData = await _dashboardService.GetDashboardAsync();
            return View(dashboardData);
        }

        [HttpPost("approve")]
        public async Task<IActionResult> Approve(Guid courseId)
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
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("reject")]
        public async Task<IActionResult> Reject(Guid courseId, string rejectReason)
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
        public async Task<IActionResult> Publish(Application.Dtos.Manager.PublishCourseRequest request)
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
        public async Task<IActionResult> CourseDetail(Guid id)
        {
            try
            {
                var courseDetail = await _dashboardService.GetCourseDetailAsync(id);
                return View(courseDetail);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Dashboard));
            }
        }






    }

}
