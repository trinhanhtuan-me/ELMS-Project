using Application.Dtos.StudentProfile;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class StudentProfileController : Controller
    {
        private readonly IStudentProfileService _profileService;
        public StudentProfileController(IStudentProfileService profileService)
        {
            _profileService = profileService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(userIdStr, out Guid userId)) return RedirectToAction("Login", "Identity");
                var profile = await _profileService.GetProfileAsync(userId);
                return View(profile);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] StudentProfileVm model)
        {
            try
            {
                var userIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(userIdStr, out Guid userId)) return RedirectToAction("Login", "Identity");
                model.UserId = userId;
                await _profileService.UpdateProfileAsync(model);
                TempData["SuccessToast"] = "Profile updated successfully!";
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
