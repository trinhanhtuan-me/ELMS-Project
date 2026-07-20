using Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class MyProgressController : Controller
    {
        private readonly IStudentProgressService _progressService;
        public MyProgressController(IStudentProgressService progressService)
        {
            _progressService = progressService;
        }
        public async Task<IActionResult> Index()
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid studentId))
            {
                return RedirectToAction("Login", "Identity");
            }
            var courses = await _progressService.GetMyCoursesAsync(studentId);

            return View(courses);
        }
    }
}
