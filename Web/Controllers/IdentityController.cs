using Application.Dtos.Identity;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

namespace Web.Controllers
{
    public class IdentityController(IIdentityService _identity) : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (!ModelState.IsValid) return View(request);

            try
            {
                await _identity.RegisterAsync(request);
                TempData["SuccessToast"] = "Registration successful! Please check your email to verify your account.";
                return RedirectToAction("VerifyAccount", new { email = request.Email });
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

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            try
            {
                var user = await _identity.LoginAsync(request);

                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.FullName ?? user.Username),
                    new Claim(ClaimTypes.Email, user.Email),
                };

                if (user.Roles != null)
                {
                    foreach (var role in user.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.Name));
                    }
                }

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = request.IsRemember,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }
            catch (BusinessRuleException ex)
            {
                if (ex.Message == "This account is not verified")
                {
                    TempData["UnverifiedIdentifier"] = request.Identifier;
                }
                TempData["ErrorToast"] = ex.Message;
                return View(request);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult VerifyAccount(string email)
        {
            var request = new VerifyAccountRequest(email, string.Empty);
            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> VerifyAccount(VerifyAccountRequest request)
        {
            if (!ModelState.IsValid) return View(request);

            try
            {
                await _identity.VerifyEmailAsync(request);
                TempData["SuccessToast"] = "Account verified successfully! You can now sign in.";
                return RedirectToAction("Login");

            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return View(request);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ResendVerifyOtp(string email)
        {
            try
            {
                await _identity.ResendOtpAsync(email);

                TempData["SuccessMessage"] = "A new OTP has been sent to your email.";

                return RedirectToAction("VerifyAccount", new { email = email });
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Login");
            }
        }

    }
}
