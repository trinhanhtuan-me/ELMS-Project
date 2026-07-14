using Application.Dtos.Course;
using Application.UseCases;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ICategoryService _categoryService;

        public CourseController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync();

            var courses = await _courseService.GetCoursesByInstructorAsync(instructorId);
            return View(courses);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

           
            var course = await _courseService.GetCourseDetailsAsync(id, instructorId);

            if (course == null) return NotFound();

            return View("Views/Module/Details.cshtml",course);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CourseUpsertRequest request)
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

                await _courseService.CreateCourseAsync(request, createdBy);
                TempData["SuccessToast"] = "Course created successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = $"Error creating course: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] CourseUpsertRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorToast"] = "Please fill all required fields.";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (!Guid.TryParse(userIdStr, out Guid instructorId)) return RedirectToAction(nameof(Index));

                var success = await _courseService.UpdateCourseAsync(request, instructorId);
                if (success) TempData["SuccessToast"] = "Course updated successfully!";
                else TempData["ErrorToast"] = "Failed to update course.";

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = $"Error updating course: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _courseService.SoftDeleteCourseAsync(id, instructorId);
                if (success) TempData["SuccessToast"] = "Course deleted successfully!";
                else TempData["ErrorToast"] = "Failed to delete course.";
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Submit(Guid id)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (Guid.TryParse(userIdStr, out Guid instructorId))
            {
                var success = await _courseService.SubmitCourseAsync(id, instructorId);
                if (success) TempData["SuccessToast"] = "Course submitted successfully!";
                else TempData["ErrorToast"] = "Failed to submit course.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
