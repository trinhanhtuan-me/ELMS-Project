using Application.Dtos.Module;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;

        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModuleRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("Details", "Course", new { id = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _moduleService.CreateModuleAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Module created successfully!";
                else TempData["ErrorToast"] = "Failed to create module.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ModuleRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction("Details", "Course", new { id = request.CourseId });
            }

            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _moduleService.UpdateModuleAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Module updated successfully!";
                else TempData["ErrorToast"] = "Failed to update module.";
            }

            return RedirectToAction("Details", "Course", new { id = request.CourseId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id, Guid courseId)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _moduleService.DeleteModuleAsync(id, instructorId);
                if (success) TempData["SuccessToast"] = "Module deleted successfully!";
                else TempData["ErrorToast"] = "Failed to delete module.";
            }

            return RedirectToAction("Details", "Course", new { id = courseId });
        }
    }
}
