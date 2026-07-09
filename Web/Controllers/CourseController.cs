using Application.Dtos.Course;
using Application.UseCases;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ElmsDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(ICourseService courseService, ElmsDbContext context, IWebHostEnvironment env)
        {
            _courseService = courseService;
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

            ViewBag.Categories = _context.Categories.ToList();

            var courses = await _courseService.GetCoursesByInstructorAsync(instructorId);
            return View(courses);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCourseRequest request, IFormFile? thumbnailFile)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!Guid.TryParse(userIdStr, out Guid createdBy))
                {
                    TempData["ErrorToast"] = "User identity is invalid.";
                    return RedirectToAction(nameof(Index));
                }

                Stream? fileStream = null;
                string? fileName = null;
                if (thumbnailFile != null && thumbnailFile.Length > 0)
                {
                    fileStream = thumbnailFile.OpenReadStream();
                    fileName = thumbnailFile.FileName;
                }

                await _courseService.CreateCourseAsync(request, fileStream, fileName, createdBy);
                TempData["SuccessToast"] = "Course created successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = $"Error creating course: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
