using Application.Dtos.InstructorAssignment;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    [Authorize]
    public class InstructorAssignmentController : Controller
    {
        private readonly IInstructorAssignmentService _assignmentService;

        public InstructorAssignmentController(IInstructorAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

            int pageSize = 10;
            var pagedResult = await _assignmentService.GetPagedSubmittedAssignmentsAsync(instructorId, pageIndex, pageSize);
            
            return View(pagedResult);
        }

        public async Task<IActionResult> Grade(Guid assignmentId, Guid studentId)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

            var aw = await _assignmentService.GetAssignmentWorkDetailsAsync(assignmentId, studentId, instructorId);
            if (aw == null)
            {
                return NotFound("Assignment submission not found or you don't have permission to grade it.");
            }

            var vm = new GradeAssignmentViewModel
            {
                AssignmentId = aw.AssignmentId,
                StudentId = aw.StudentId,
                Score = aw.Score ?? 0,
                StudentName = aw.StudentName,
                CourseTitle = aw.CourseTitle,
                AssignmentTitle = aw.AssignmentTitle,
                TextAnswer = aw.TextAnswer,
                FileUrl = aw.FileUrl,
                MaxScore = aw.MaxScore,
                SubmittedAt = aw.SubmittedAt
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitGrade(GradeAssignmentViewModel model)
        {
            var userIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdStr, out Guid instructorId))
            {
                return RedirectToAction("Login", "Identity");
            }

            if (!ModelState.IsValid)
            {
                // re-fetch read-only data because it was lost on POST
                var aw = await _assignmentService.GetAssignmentWorkDetailsAsync(model.AssignmentId, model.StudentId, instructorId);
                if (aw != null)
                {
                    model.StudentName = aw.StudentName;
                    model.CourseTitle = aw.CourseTitle;
                    model.AssignmentTitle = aw.AssignmentTitle;
                    model.TextAnswer = aw.TextAnswer;
                    model.FileUrl = aw.FileUrl;
                    model.MaxScore = aw.MaxScore;
                    model.SubmittedAt = aw.SubmittedAt;
                }
                return View("Grade", model);
            }

            var dto = new GradeAssignmentDto
            {
                AssignmentId = model.AssignmentId,
                StudentId = model.StudentId,
                Score = model.Score,
                Feedback = model.Feedback
            };

            var success = await _assignmentService.GradeAssignmentAsync(dto, instructorId);

            if (success)
            {
                TempData["SuccessToast"] = "Assignment graded successfully!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorToast"] = "Failed to grade assignment.";
                return RedirectToAction("Index");
            }
        }
    }
}
