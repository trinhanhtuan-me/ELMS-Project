using Application.Dtos.Manager;
using Application.Exceptions;
using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize(Roles = "Manager")] 
    [Route("manager")]
    public class ManagerController(IManagerDashboardService _dashboardService , IManagerCourseService _managerCourseService, IManagerCategoryService _categoryService, IManagerProfileService _profileService, IManagerFlashcardService _flashcardService  ,IManagerRevenueService _revenueService) : Controller
    {
        [HttpGet("dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var dashboardData = await _dashboardService.GetDashboardAsync();
            return View(dashboardData);
            
        }

        [HttpPost("approve")]
        public async Task<IActionResult> Approve(Guid courseId,  [FromForm] string source)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            var result = await _dashboardService.ApproveCourseAsync(courseId);
            if (result)
            {
                TempData["SuccessToast"] = "Approve Success!";
            }
            if (source == "management") return RedirectToAction(nameof(CourseManagement));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("reject")]
        public async Task<IActionResult> Reject(Guid courseId, string rejectReason, [FromForm] string source)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            var result = await _dashboardService.RejectCourseAsync(courseId, managerId, rejectReason);
            if (result)
            {
                TempData["SuccessToast"] = "Reject Success!";
            }
            if (source == "management") return RedirectToAction(nameof(CourseManagement));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("unpublish")]
        public async Task<IActionResult> Unpublish(Guid courseId, [FromForm] string? source)
        {
            try
            {
                await _dashboardService.UnpublishCourseAsync(courseId);
                TempData["SuccessToast"] = "UnPublish Success!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }

            if (source == "publish") return RedirectToAction(nameof(CoursePublish));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpPost("publish")]
        public async Task<IActionResult> Publish(PublishCourseRequest request, [FromForm] string? source)
        {
            ModelState.Remove(nameof(request.PublishDate));

            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .FirstOrDefault();

                TempData["ErrorToast"] = errorMessage ?? "Invalid Validation";
                if (source == "publish") return RedirectToAction(nameof(CoursePublish));
                return RedirectToAction(nameof(Dashboard));
            }

            try
            {
                await _dashboardService.PublishCourseAsync(request.CourseId, DateTime.Now, request.Price);
                TempData["SuccessToast"] = "Publish Success!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }

            if (source == "publish") return RedirectToAction(nameof(CoursePublish));
            return RedirectToAction(nameof(Dashboard));
        }

        [HttpGet("course-detail/{id}")]
        public async Task<IActionResult> CourseDetail(Guid id, [FromQuery] string source = "dashboard")
        {
            try
            {
                var courseDetail = await _dashboardService.GetCourseDetailAsync(id);
                ViewBag.Source = source;
                return View(courseDetail);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction(nameof(Dashboard));
            }
        }

        [HttpGet("course-management")]
        public IActionResult CourseManagement()
        {
            return View();
        }

        [HttpGet("api/courses")]
        public async Task<IActionResult> GetCoursesApi(
            [FromQuery] string status = "all",
            [FromQuery] string keyword = "",
            [FromQuery] int categoryId = 0,
            [FromQuery] string sort = "newest",
            [FromQuery] int page = 1,
            [FromQuery] int size = 10)
        {
            var response = await _managerCourseService.GetFilteredCoursesAsync(status, keyword, categoryId, sort, page, size);

            return Json(response);
        }

        [HttpPost("api/bulk-approve")]
        public async Task<IActionResult> BulkApprove([FromBody] List<Guid> courseIds)
        {
            if (courseIds == null || !courseIds.Any()) return BadRequest("No courses selected.");

            try
            {
                foreach (var id in courseIds)
                {
                    await _dashboardService.ApproveCourseAsync(id);
                }
                TempData["SuccessToast"] = "Approve Success!";
            }
            catch (BusinessRuleException ex) 
            {
                TempData["ErrorToast"] = ex.Message;
            }
            catch (Exception ex) 
            {
                TempData["ErrorToast"] = "Error : " + ex.Message;
            }

            return Ok();
        }

        [HttpPost("api/bulk-reject")]
        public async Task<IActionResult> BulkReject([FromBody] BulkRejectRequest request)
        {
            if (request.CourseIds == null || !request.CourseIds.Any()) return BadRequest("No courses selected.");

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId) || !Guid.TryParse(userId, out Guid managerId))
            {
                return Unauthorized("Need to login");
            }

            try
            {
                foreach (var id in request.CourseIds)
                {
                    await _dashboardService.RejectCourseAsync(id, managerId, request.Reason);
                }
                TempData["SuccessToast"] = "Reject Success!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error: " + ex.Message;
            }

            return Ok();
        }

        [HttpGet("course-publish")]
        public IActionResult CoursePublish()
        {
            return View();
        }

        [HttpGet("category-management")]
        public IActionResult CategoryManagement()
        {
            return View();
        }

        [HttpGet("api/categories")]
        public async Task<IActionResult> GetCategoriesApi()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Json(categories);
        }

        [HttpPost("api/categories/save")]
        public async Task<IActionResult> SaveCategoryApi([FromForm] CategorySaveRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .FirstOrDefault();

                TempData["ErrorToast"] = errorMessage ?? "Invalid Validation";
                return BadRequest();
            }

            try
            {
                await _categoryService.SaveCategoryAsync(request);
                TempData["SuccessToast"] = "Save Category Success!";
                return Ok();
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return BadRequest();
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "System Error: " + ex.Message;
                return StatusCode(500);
            }
        }

        [HttpPost("api/categories/delete/{id}")]
        public async Task<IActionResult> DeleteCategoryApi(int id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                TempData["SuccessToast"] = "Category deleted successfully!";
                return Ok();
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "System Error: " + ex.Message;
                return StatusCode(500);
            }
        }

        [HttpGet("change-password")]
        public IActionResult ChangePassword()
        {
            return View("ChangePassword");
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromForm] ChangePasswordRequest request)
        {
            if (!ModelState.IsValid)
            {
                var firstError = ModelState.Values.SelectMany(v => v.Errors).FirstOrDefault()?.ErrorMessage;
                TempData["ErrorToast"] = firstError;
                return View("ChangePassword");
            }

            var userIdString = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid userId))
            {
                return RedirectToAction("Login", "Identity");
            }

            try
            {
                
                await _profileService.ChangePasswordAsync(userId, request);

                TempData["SuccessToast"] = "Your password has been successfully changed!";
                return RedirectToAction("ChangePassword");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return View("ChangePassword");
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "System Error!";
                return View("ChangePassword");
            }
        }

        [HttpGet("flashcards")]
        public async Task<IActionResult> FlashcardManagement(string? keyword, string? sort)
        {
            var sets = await _flashcardService.GetFlashcardSetsAsync(keyword ?? "", sort ?? "newest");

            ViewData["keyword"] = keyword;
            ViewData["sortType"] = sort ?? "newest";

            return View("FlashcardManagement", sets);
        }

        [HttpGet("flashcards/detail")]
        public async Task<IActionResult> FlashcardDetail(Guid setId)
        {
            try
            {
                var set = await _flashcardService.GetFlashcardSetDetailAsync(setId);
                var cards = await _flashcardService.GetFlashcardsBySetIdAsync(setId);

                ViewData["Cards"] = cards;

                return View("FlashcardDetail", set); 
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("FlashcardManagement");
            }
        }

        [HttpPost("flashcards/toggle-status")]
        public async Task<IActionResult> ToggleFlashcardStatus([FromForm] Guid setId, [FromForm] string action)
        {
            try
            {
                string mappedAction = action == "hide" ? "hideSet" : "activateSet";
                await _flashcardService.ToggleSetStatusAsync(setId, mappedAction);

                TempData["SuccessToast"] = "Status updated successfully!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }

            return RedirectToAction("FlashcardManagement");
        }

        [HttpGet("revenue-report")]
        public async Task<IActionResult> RevenueReport([FromQuery] string type = "month", [FromQuery] int? year = null)
        {
            var currentYear = DateTime.Now.Year;
            var targetYear = year ?? currentYear;

            try
            {
                if (type == "year")
                {
                    var yearlyReports = await _revenueService.GetYearlyReportAsync();
                    ViewData["reports"] = yearlyReports;
                    ViewData["reportType"] = "year";
                }
                else
                {
                    var monthlyReports = await _revenueService.GetMonthlyReportAsync(targetYear);
                    ViewData["reports"] = monthlyReports;
                    ViewData["reportType"] = "month";
                    ViewData["selectedYear"] = targetYear;
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error loading report data: " + ex.Message;
            }

            return View();
        }

        [HttpGet("revenue-export")]
        public async Task<IActionResult> RevenueExport([FromQuery] string type = "month", [FromQuery] int? year = null)
        {
            try
            {
                var targetYear = year ?? DateTime.Now.Year;
                List<RevenueReportVm> reports;

                if (type == "year")
                {
                    reports = await _revenueService.GetYearlyReportAsync();
                }
                else
                {
                    reports = await _revenueService.GetMonthlyReportAsync(targetYear);
                }

                var csvBytes = _revenueService.GenerateCsvBytes(reports, type);
                var fileName = $"RevenueReport_{type}_{targetYear}.csv";

                return File(csvBytes, "text/csv", fileName);
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error exporting revenue report: " + ex.Message;
                return RedirectToAction(nameof(RevenueReport));
            }
        }

        [HttpGet("profile")]
        public async Task<IActionResult> ManagerProfile()
        {
            try
            {
                var userIdString = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid userId))
                {
                    return RedirectToAction("Login", "Identity");
                }
                var profile = await _profileService.GetProfileAsync(userId);

                return View(profile);
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error loading profile: " + ex.Message;
                return RedirectToAction(nameof(Dashboard));
            }
        }

        [HttpPost("profile")]
        public async Task<IActionResult> ManagerProfile([FromForm] ManagerProfileVm model)
        {
            if (!ModelState.IsValid)
            {
                var firstError = ModelState.Values.SelectMany(v => v.Errors).FirstOrDefault()?.ErrorMessage;
                TempData["ErrorToast"] = firstError;
                return View(model);
            }
            try
            {
                var userIdString = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid userId))
                {
                    return RedirectToAction("Login", "Identity");
                }

                model.UserId = userId; 
                await _profileService.UpdateProfileAsync(model);

                TempData["SuccessToast"] = "Profile updated successfully!";
                return RedirectToAction(nameof(ManagerProfile)); 
            }
            catch (Exception ex)
            {
                TempData["ErrorToast"] = "Error updating profile: " + ex.Message;
                return View(model);
            }
        }




    }

}
