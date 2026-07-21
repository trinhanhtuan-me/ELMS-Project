using Application.Dtos.InstructorProfile;
using Application.Dtos.SecurityManagement;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class InstructorProfileController : Controller
    {
        private readonly IInstructorProfileService _profileService;
        private readonly IIdentityService _identity;
        private readonly IPasskeyService _passkey;

        public InstructorProfileController(
            IInstructorProfileService profileService,
            IIdentityService identity,
            IPasskeyService passkey)
        {
            _profileService = profileService;
            _identity = identity;
            _passkey = passkey;
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
                return RedirectToAction("Index", "Course");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromForm] InstructorProfileVm model)
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

        [HttpGet]
        public async Task<IActionResult> Security()
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
            if (!string.IsNullOrEmpty(userEmail))
            {
                ViewBag.HasPasskey = await _passkey.HasPasskey(userEmail);
            }
            else
            {
                ViewBag.HasPasskey = false;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please enter correct password information";
                return RedirectToAction("Security");
            }

            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!string.IsNullOrEmpty(userIdString) && Guid.TryParse(userIdString, out Guid userId))
                {
                    await _identity.ChangePassword(userId, request);
                    TempData["SuccessToast"] = "Password changed successfully!";
                }
                return RedirectToAction("Security");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Security");
            }
        }
    }
}
