using Application.Dtos.SecurityManagement;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class SecurityManagementController(IPasskeyService _passkey, IIdentityService _identity) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
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
                return RedirectToAction("Index");
            }

            try
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!string.IsNullOrEmpty(userIdString)
                    && Guid.TryParse(userIdString, out Guid userId))
                {
                    await _identity.ChangePassword(userId, request);
                    TempData["SuccessToast"] = "Password changed successfully!";
                }
                return RedirectToAction("Index");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
