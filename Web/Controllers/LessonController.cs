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
    public class LessonController : Controller
    {
        private readonly ILessonService _lessonService;
        private readonly IModuleService _moduleService;

        public LessonController(ILessonService lessonService, IModuleService moduleService)
        {
            _lessonService = lessonService;
            _moduleService = moduleService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateVideoLesson(Guid moduleId, Guid courseId)
        {
            ViewBag.ModuleId = moduleId;
            ViewBag.CourseId = courseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(courseId);
            return View(new VideoLessonCreateRequest { ModuleId = moduleId, CourseId = courseId });
        }

        [HttpPost]
        [RequestSizeLimit(104857600)] // 100 MB limit
        [RequestFormLimits(MultipartBodyLengthLimit = 104857600)]
        public async Task<IActionResult> CreateVideoLesson([FromForm] VideoLessonCreateRequest request)
        {
            if (request == null)
            {
                TempData["ErrorToast"] = "Request is null or file is too large (max 100MB).";
                return RedirectToAction("Index", "Course"); // Fallback
            }

            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("CreateVideoLesson", new { moduleId = request.ModuleId, courseId = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var newId = await _lessonService.CreateVideoLessonAsync(request, instructorId);
                if (newId != null) 
                {
                    TempData["SuccessToast"] = "Video Lesson created successfully!";
                    return RedirectToAction("UpdateVideoLesson", new { lessonId = newId.Value });
                }
                else TempData["ErrorToast"] = "Failed to create video lesson.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateVideoLesson(Guid lessonId)
        {
            var model = await _lessonService.GetVideoLessonForUpdateAsync(lessonId);
            if (model == null) return NotFound();

            ViewBag.ModuleItemId = lessonId;
            ViewBag.ModuleId = model.ModuleId;
            ViewBag.CourseId = model.CourseId;
            ViewBag.ActualLessonId = model.ActualLessonId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(model.CourseId);

            return View(model);
        }

        [HttpPost]
        [RequestSizeLimit(104857600)]
        [RequestFormLimits(MultipartBodyLengthLimit = 104857600)]
        public async Task<IActionResult> UpdateVideoLesson([FromForm] VideoLessonUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("UpdateVideoLesson", new { lessonId = request.ModuleItemId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _lessonService.UpdateVideoLessonAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Video Lesson updated successfully!";
                else TempData["ErrorToast"] = "Failed to update video lesson.";
            }

            return RedirectToAction("UpdateVideoLesson", new { lessonId = request.ModuleItemId });
        }

        [HttpGet]
        public async Task<IActionResult> CreateReadingLesson(Guid moduleId, Guid courseId)
        {
            ViewBag.ModuleId = moduleId;
            ViewBag.CourseId = courseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(courseId);
            return View(new ReadingLessonCreateRequest { ModuleId = moduleId, CourseId = courseId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateReadingLesson([FromForm] ReadingLessonCreateRequest request)
        {
            if (request == null)
            {
                TempData["ErrorToast"] = "Request is invalid.";
                return RedirectToAction("Index", "Course");
            }

            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("CreateReadingLesson", new { moduleId = request.ModuleId, courseId = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var newId = await _lessonService.CreateReadingLessonAsync(request, instructorId);
                if (newId != null) 
                {
                    TempData["SuccessToast"] = "Reading Lesson created successfully!";
                    return RedirectToAction("UpdateReadingLesson", new { lessonId = newId.Value });
                }
                else TempData["ErrorToast"] = "Failed to create reading lesson.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateReadingLesson(Guid lessonId)
        {
            var model = await _lessonService.GetReadingLessonForUpdateAsync(lessonId);
            if (model == null) return NotFound();

            ViewBag.ModuleItemId = lessonId;
            ViewBag.ModuleId = model.ModuleId;
            ViewBag.CourseId = model.CourseId;
            ViewBag.ActualLessonId = model.ActualLessonId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(model.CourseId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateReadingLesson([FromForm] ReadingLessonUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("UpdateReadingLesson", new { lessonId = request.ModuleItemId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _lessonService.UpdateReadingLessonAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Reading Lesson updated successfully!";
                else TempData["ErrorToast"] = "Failed to update reading lesson.";
            }

            return RedirectToAction("UpdateReadingLesson", new { lessonId = request.ModuleItemId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLesson(Guid moduleItemId, Guid courseId)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _lessonService.DeleteLessonAsync(moduleItemId, instructorId);
                if (success) TempData["SuccessToast"] = "Lesson deleted successfully!";
                else TempData["ErrorToast"] = "Failed to delete lesson.";
            }

            return RedirectToAction("Details", "Course", new { id = courseId });
        }
    }
}
