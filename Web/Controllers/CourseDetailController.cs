using Application.Dtos.CourseRequest;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class CourseDetailController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseDetailController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            Guid? studentId = null;
            if (Guid.TryParse(userIdStr, out Guid parsedId))
            {
                studentId = parsedId;
            }
            try
            {
                var details = await _courseService.GetPublicCourseDetailsAsync(id, studentId);
                return View(details);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> RequestCourse([FromForm] Guid courseId, [FromServices] ICourseRequestService courseRequestService)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid studentId))
            {
                return RedirectToAction("Login", "Identity");
            }
            try
            {
                var saveRequest = new SaveCourseRequest(studentId, courseId);
                await courseRequestService.SaveCourseRequest(saveRequest);
                TempData["SuccessToast"] = "Course added to your saved list!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction(nameof(Index), new { id = courseId });
        }
    }
}
