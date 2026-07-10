using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class SecurityManagementController(IPasskeyService _passkey) : Controller
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
    }
}
