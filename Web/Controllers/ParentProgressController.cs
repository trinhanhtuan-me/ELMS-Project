using Application.Exceptions;
using Application.UseCases;
using Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentProgressController(IParentProgressService progressService, ILocalizationService localizer) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var parentId = GetCurrentUserId();
                var children = await progressService.GetChildrenSummaryAsync(parentId);
                return View("~/Views/Parent/Progress/Index.cshtml", children);
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ChildCourses(Guid studentId)
        {
            try
            {
                var parentId = GetCurrentUserId();
                var courses = await progressService.GetChildCoursesProgressAsync(parentId, studentId);
                
                // Fetch student info for Breadcrumb/ViewBag
                ViewBag.StudentId = studentId;
                return View("~/Views/Parent/Progress/ChildCourses.cshtml", courses);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> CourseDetail(Guid studentId, Guid courseId)
        {
            try
            {
                var parentId = GetCurrentUserId();
                var modules = await progressService.GetCourseDetailProgressAsync(parentId, studentId, courseId);
                
                ViewBag.StudentId = studentId;
                ViewBag.CourseId = courseId;
                return View("~/Views/Parent/Progress/CourseDetail.cshtml", modules);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("ChildCourses", new { studentId });
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("ChildCourses", new { studentId });
            }
        }

        private Guid GetCurrentUserId()
        {
            var idClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(idClaim) || !Guid.TryParse(idClaim, out var userId))
            {
                throw new UnauthorizedAccessException("Không xác thực được người dùng.");
            }
            return userId;
        }
    }
}
