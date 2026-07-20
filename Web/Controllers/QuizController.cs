using Application.Dtos.Lesson;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizService _quizService;
        private readonly IModuleService _moduleService;

        public QuizController(IQuizService quizService, IModuleService moduleService)
        {
            _quizService = quizService;
            _moduleService = moduleService;
        }

        private Guid GetUserId()
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out var userId))
            {
                throw new UnauthorizedAccessException("User ID is not found or invalid.");
            }
            return userId;
        }

        [HttpGet]
        public async Task<IActionResult> CreateQuiz(Guid moduleId, Guid courseId)
        {
            ViewBag.ModuleId = moduleId;
            ViewBag.CourseId = courseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(courseId);
            
            return View(new QuizCreateRequest { ModuleId = moduleId, CourseId = courseId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuiz([FromForm] QuizCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ModuleId = request.ModuleId;
                ViewBag.CourseId = request.CourseId;
                ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(request.CourseId);
                return View(request);
            }

            try
            {
                var instructorId = GetUserId();
                var newId = await _quizService.CreateQuizAsync(request, instructorId);
                
                if (newId.HasValue)
                {
                    TempData["SuccessToast"] = "Tạo bài kiểm tra thành công!";
                    return RedirectToAction("UpdateQuiz", new { lessonId = newId.Value });
                }
                
                ModelState.AddModelError(string.Empty, "Không thể tạo bài kiểm tra. Vui lòng kiểm tra lại quyền truy cập.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Đã xảy ra lỗi: {ex.Message}");
            }

            ViewBag.ModuleId = request.ModuleId;
            ViewBag.CourseId = request.CourseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(request.CourseId);
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateQuiz(Guid lessonId)
        {
            var model = await _quizService.GetQuizForUpdateAsync(lessonId);
            if (model == null)
            {
                TempData["ErrorToast"] = "Không tìm thấy bài kiểm tra!";
                return RedirectToAction("Index", "Course");
            }

            ViewBag.ModuleId = model.ModuleId;
            ViewBag.CourseId = model.CourseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(model.CourseId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuiz([FromForm] QuizUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ModuleId = request.ModuleId;
                ViewBag.CourseId = request.CourseId;
                ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(request.CourseId);
                return View(request);
            }

            try
            {
                var instructorId = GetUserId();
                var success = await _quizService.UpdateQuizAsync(request, instructorId);
                
                if (success)
                {
                    TempData["SuccessToast"] = "Cập nhật bài kiểm tra thành công!";
                    return RedirectToAction("UpdateQuiz", new { lessonId = request.ModuleItemId });
                }

                ModelState.AddModelError(string.Empty, "Không thể cập nhật bài kiểm tra. Vui lòng kiểm tra lại quyền truy cập.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Đã xảy ra lỗi: {ex.Message}");
            }

            ViewBag.ModuleId = request.ModuleId;
            ViewBag.CourseId = request.CourseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(request.CourseId);
            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteQuiz(Guid moduleItemId, Guid courseId)
        {
            try
            {
                var instructorId = GetUserId();
                var success = await _quizService.DeleteQuizAsync(moduleItemId, courseId, instructorId);
                if (success)
                {
                    TempData["SuccessToast"] = "Đã xóa bài kiểm tra thành công!";
                }
                else
                {
                    TempData["ErrorToast"] = "Không thể xóa bài kiểm tra. Vui lòng thử lại.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = $"Lỗi khi xóa: {ex.Message}";
            }

            return RedirectToAction("Details", "Module", new { id = courseId });
        }
    }
}
