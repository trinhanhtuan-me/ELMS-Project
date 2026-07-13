using Application.Dtos.Identity;
using Application.Dtos.Passkey;
using Application.Exceptions;
using Application.UseCases;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Principal;

namespace Web.Controllers
{
    public class IdentityController(IIdentityService _identity, IPasskeyService _passkey) : Controller
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
            if (User.Identity != null && User.Identity.IsAuthenticated) 
                return RedirectToAction("Index", "Home");
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

                if (user.Roles != null && user.Roles.Count == 1)
                {
                    var roleName = user.Roles.First().Name;
                    if (roleName.ToLower().Contains("student")) return RedirectToAction("Index", "Home");
                    if (roleName.ToLower().Contains("instructor")) return RedirectToAction("Index", "???");
                    if (roleName.ToLower().Contains("manager")) return RedirectToAction("Index", "???");
                    if (roleName.ToLower().Contains("parent")) return RedirectToAction("Index", "???");
                    if (roleName.ToLower().Contains("admin")) return RedirectToAction("Index", "???");
                }
                else if (user.Roles != null && user.Roles.Count > 1)
                {
                    return RedirectToAction("SelectRole", "Identity");
                }

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
                await _identity.VerifyAccountAsync(request);
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
                await _identity.ResendRegisterOtpAsync(email);

                TempData["SuccessMessage"] = "A new OTP has been sent to your email.";

                return RedirectToAction("VerifyAccount", new { email = email });
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Login");
            }
        }


        //Passkey
        [HttpPost]
        public async Task<IActionResult> MakeCredentialOptions([FromBody] PasskeyOptionsRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { error = "Invalid data." });

            try
            {
                var options = await _passkey.RequestPasskeyRegistration(request);
                return Json(options);
            }
            catch (BusinessRuleException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeCredential([FromBody] RegisterPasskeyCompleteRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { error = "Invalid data." });

            try
            {
                await _passkey.CompletePasskeyRegistration(request);
                return Json(new { status = "ok", message = "Passkey registered successfully!" });
            }
            catch (BusinessRuleException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeAssertionOptions([FromBody] PasskeyOptionsRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { error = "Invalid data." });

            try
            {
                var options = await _passkey.RequestPasskeyLogin(request);
                return Json(options);
            }
            catch (BusinessRuleException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeAssertion([FromBody] CompletePasskeyLoginRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(new { error = "Invalid data." });

            try
            {
                var user = await _passkey.CompletePasskeyLogin(request);
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
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7)
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimIdentity), authProperties);

                return Json(new { status = "ok", redirectUrl = Url.Action("Index", "Home") });
            }
            catch (BusinessRuleException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            try
            {
                await _identity.ForgotPasswordAsync(request);
                TempData["SuccessToast"] = "Please check your email for the OTP code.";
                return RedirectToAction("VerifyForgotPassword", new { Email = request.Email });
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("ForgotPassword");
            }
        }

        [HttpGet]
        public IActionResult VerifyForgotPassword(string email)
        {
            var model = new VerifyForgotPasswordRequest { Email = email };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> VerifyForgotPassword(VerifyForgotPasswordRequest request)
        {
            if (!ModelState.IsValid) return View(request);

            try
            {
                await _identity.VerifyForgotPasswordAsync(request);
                return RedirectToAction("ResetPassword",
                    new { email = request.Email, otp = request.Code });
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return View(request);
            }
        }

        [HttpGet]
        public IActionResult ResetPassword(string email, string otp)
        {
            var model = new ResetPasswordRequest { Email = email, Code = otp };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            if (!ModelState.IsValid) return View(request);
            try
            {
                await _identity.ResetPassword(request);

                TempData["SuccessToast"] = "Your password has been reset successfully. Please login.";
                return RedirectToAction("Login");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return View(request);
            }
        }

        [HttpGet]
        public IActionResult SelectRole()
        {
            var role = User.Claims.Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value).ToList();

            if (role.Count < 1) return RedirectToAction("Index", "Home");

            return View(role);
        }
    }
}
