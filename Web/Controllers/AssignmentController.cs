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
    public class AssignmentController : Controller
    {
        private readonly IAssignmentService _assignmentService;
        private readonly IModuleService _moduleService;
        private readonly ILessonService _lessonService;

        public AssignmentController(IAssignmentService assignmentService, IModuleService moduleService, ILessonService lessonService)
        {
            _assignmentService = assignmentService;
            _moduleService = moduleService;
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateAssignment(Guid moduleId, Guid courseId)
        {
            ViewBag.ModuleId = moduleId;
            ViewBag.CourseId = courseId;
            ViewBag.Modules = await _moduleService.GetModulesWithItemsAsync(courseId);
            return View(new AssignmentCreateRequest { ModuleId = moduleId, CourseId = courseId });
        }

        [HttpPost]
        [RequestSizeLimit(104857600)]
        [RequestFormLimits(MultipartBodyLengthLimit = 104857600)]
        public async Task<IActionResult> CreateAssignment([FromForm] AssignmentCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("CreateAssignment", new { moduleId = request.ModuleId, courseId = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var newId = await _assignmentService.CreateAssignmentAsync(request, instructorId);
                if (newId != null) 
                {
                    TempData["SuccessToast"] = "Assignment created successfully!";
                    return RedirectToAction("UpdateAssignment", new { lessonId = newId.Value });
                }
                else TempData["ErrorToast"] = "Failed to create assignment.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAssignment(Guid lessonId)
        {
            var model = await _assignmentService.GetAssignmentForUpdateAsync(lessonId);
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
        public async Task<IActionResult> UpdateAssignment([FromForm] AssignmentUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("UpdateAssignment", new { lessonId = request.ModuleItemId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _assignmentService.UpdateAssignmentAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Assignment updated successfully!";
                else TempData["ErrorToast"] = "Failed to update assignment.";
            }

            return RedirectToAction("UpdateAssignment", new { lessonId = request.ModuleItemId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAssignment(Guid moduleItemId, Guid courseId)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _lessonService.DeleteLessonAsync(moduleItemId, instructorId);
                if (success) TempData["SuccessToast"] = "Assignment deleted successfully!";
                else TempData["ErrorToast"] = "Failed to delete assignment.";
            }

            return RedirectToAction("Details", "Course", new { id = courseId });
        }
    }
}
