using Application.Dtos.Identity;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Web.Controllers
{
    public class IdentityController(IIdentityService _service) : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            try
            {
                await _service.RegisterAsync(request);
                return RedirectToAction("Login");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return View(request);
            }

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

    }
}