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
    public class DiscussionController : Controller
    {
        private readonly IDiscussionService _discussionService;
        private readonly IModuleService _moduleService;
        private readonly ILessonService _lessonService;

        public DiscussionController(IDiscussionService discussionService, IModuleService moduleService, ILessonService lessonService)
        {
            _discussionService = discussionService;
            _moduleService = moduleService;
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateDiscussion(Guid moduleId, Guid courseId)
        {
            ViewBag.ModuleId = moduleId;
            ViewBag.CourseId = courseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(courseId);
            return View(new DiscussionCreateRequest { ModuleId = moduleId, CourseId = courseId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscussion([FromForm] DiscussionCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("CreateDiscussion", new { moduleId = request.ModuleId, courseId = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var newId = await _discussionService.CreateDiscussionAsync(request, instructorId);
                if (newId != null) 
                {
                    TempData["SuccessToast"] = "Discussion created successfully!";
                    return RedirectToAction("UpdateDiscussion", new { lessonId = newId.Value });
                }
                else TempData["ErrorToast"] = "Failed to create discussion.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDiscussion(Guid lessonId)
        {
            var model = await _discussionService.GetDiscussionForUpdateAsync(lessonId);
            if (model == null) return NotFound();

            ViewBag.ModuleItemId = lessonId;
            ViewBag.ModuleId = model.ModuleId;
            ViewBag.CourseId = model.CourseId;
            ViewBag.ActualLessonId = model.ActualLessonId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(model.CourseId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDiscussion([FromForm] DiscussionUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("UpdateDiscussion", new { lessonId = request.ModuleItemId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _discussionService.UpdateDiscussionAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Discussion updated successfully!";
                else TempData["ErrorToast"] = "Failed to update discussion.";
            }

            return RedirectToAction("UpdateDiscussion", new { lessonId = request.ModuleItemId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDiscussion(Guid moduleItemId, Guid courseId)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _lessonService.DeleteLessonAsync(moduleItemId, instructorId);
                if (success) TempData["SuccessToast"] = "Discussion deleted successfully!";
                else TempData["ErrorToast"] = "Failed to delete discussion.";
            }

            return RedirectToAction("Details", "Course", new { id = courseId });
        }
    }
}
