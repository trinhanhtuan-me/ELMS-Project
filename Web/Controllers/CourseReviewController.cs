using Application.Dtos.CourseReview;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class CourseReviewController : Controller
    {
        private readonly ICourseReviewService _service;
        public CourseReviewController(ICourseReviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid courseId, int? rating, int pageNumber = 1)
        {
            var request = new GetListReviewRequest(courseId, rating, 5, pageNumber);
            var listResponse = await _service.GetListCourseReview(request);
            var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (Guid.TryParse(userIdStr, out Guid studentId))
            {
                ViewBag.MyReview = await _service.GetMyReview(studentId, courseId);
            }
            else
            {
                ViewBag.MyReview = null;
            }
            return View(listResponse);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateReviewRequest request)
        {
            try
            {
                var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(userIdStr, out Guid studentId))
                {
                    return RedirectToAction("Login", "Identity");
                }
                await _service.CreateCourseReview(studentId, request);
                TempData["SuccessToast"] = "Your review has been submitted successfully!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { courseId = request.CourseId });
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] UpdateReviewRequest request)
        {
            try
            {
                var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(userIdStr, out Guid studentId))
                {
                    return RedirectToAction("Login", "Identity");
                }
                await _service.UpdateCourseReview(studentId, request);
                TempData["SuccessToast"] = "Your review has been updated successfully!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { courseId = request.CourseId });
        }
    }
}
