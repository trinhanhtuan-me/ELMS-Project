using Application.Dtos.Learning;
using Application.Exceptions;
using Application.UseCases;
using Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    public class LearningController(ILearningService _learningService) : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index(Guid courseId, Guid? itemId)
        {
            var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!Guid.TryParse(studentIdStr, out Guid studentId))
            {
                return RedirectToAction("Login", "Identity");
            }
            try
            {
                var syllabus = await _learningService.GetCourseSyllabusAsync(courseId, studentId);
                if (itemId == null)
                {
                    itemId = syllabus?.Modules?.FirstOrDefault()?.Items?.FirstOrDefault()?.ItemId;
                }
                ViewBag.CurrentItemId = itemId;
                return View(syllabus);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetItemContent(Guid itemId)
        {
            var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!Guid.TryParse(studentIdStr, out Guid studentId))
            {
                return Content("<div class='alert alert-danger'>Vui lòng đăng nhập lại.</div>", "text/html");
            }
            try
            {
                var itemInfo = await _learningService.GetItemTypeInfoAsync(itemId);

                if (itemInfo == null) return NotFound();

                switch (itemInfo.Value.ItemType)
                {
                    case ModuleItemType.Lesson:
                        if (itemInfo.Value.ContentType == LessonContentType.Video)
                        {
                            var videoContent = await _learningService.GetVideoLessonAsync(itemId, studentId);
                            return PartialView("_VideoLesson", videoContent);
                        }
                        else if (itemInfo.Value.ContentType == LessonContentType.Reading)
                        {
                            var readingContent = await _learningService.GetReadingLessonAsync(itemId, studentId);
                            return PartialView("_ReadingLesson", readingContent);
                        }
                        break;

                    case ModuleItemType.Quiz:
                        var quizContent = await _learningService.GetQuizIntroAsync(itemId, studentId);
                        return PartialView("_Quiz", quizContent);

                    case ModuleItemType.Assignment:
                        var assignmentContent = await _learningService.GetAssignmentAsync(itemId, studentId);
                        return PartialView("_Assignment", assignmentContent);
                }

                return Content("<div class='alert alert-warning'>Nội dung này chưa được hỗ trợ.</div>", "text/html");
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return Content($"<div class='alert alert-danger'>{ex.Message}</div>", "text/html");
            }
        }

        [HttpPost]
        public async Task<IActionResult> SubmitLessonQuestion(SubmitLessonQuestionRequest request)
        {
            try
            {
                var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(studentIdStr, out Guid studentId))
                {
                    return RedirectToAction("Login", "Identity");
                }
                await _learningService.SubmitLessonQuestionAsync(studentId, request);
                TempData["SuccessToast"] = "Congratulations! You have successfully completed this lesson.";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }
            return RedirectToAction("Index", new { courseId = request.CourseId, itemId = request.ModuleItemId });
        }

        [HttpPost]
        public async Task<IActionResult> MarkReadingCompleted(MarkReadingCompletedRequest request)
        {
            var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!Guid.TryParse(studentIdStr, out Guid studentId))
            {
                return RedirectToAction("Login", "Identity");
            }

            try
            {
                await _learningService.MarkReadingCompletedAsync(studentId, request.ModuleItemId);
                TempData["SuccessToast"] = "Completed reading!";
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
            }

            return RedirectToAction("Index", new { courseId = request.CourseId, itemId = request.ModuleItemId });
        }


        [HttpPost]
        public async Task<IActionResult> StartQuizAttempt(Guid itemId, Guid courseId)
        {
            try
            {
                var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(studentIdStr, out Guid studentId)) return RedirectToAction("Login", "Identity");

                var attemptId = await _learningService.StartQuizAttemptAsync(itemId, studentId);

                return RedirectToAction("TakeQuiz", new { attemptId = attemptId, courseId = courseId, itemId = itemId });
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", new { courseId = courseId, itemId = itemId });
            }
        }

        [HttpGet]
        public async Task<IActionResult> TakeQuiz(Guid attemptId, Guid courseId, Guid itemId)
        {
            try
            {
                var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(studentIdStr, out Guid studentId)) return RedirectToAction("Login", "Identity");

                var attemptDto = await _learningService.GetQuizAttemptAsync(attemptId, studentId);

                ViewBag.CourseId = courseId;
                ViewBag.ItemId = itemId;

                return View("TakeQuiz", attemptDto);
            }
            catch (BusinessRuleException ex)
            {
                TempData["ErrorToast"] = ex.Message;
                return RedirectToAction("Index", new { courseId = courseId, itemId = itemId });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SubmitQuizAttempt([FromBody] SubmitQuizAttemptRequest request, Guid courseId, Guid itemId)
        {
            try
            {
                var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(studentIdStr, out Guid studentId))
                    return Json(new { success = false, message = "Please log in to continue." });

                var score = await _learningService.SubmitQuizAttemptAsync(studentId, request);

                TempData["SuccessToast"] = $"Quiz submitted successfully! Your score: {score:0.0}%";

                return Json(new
                {
                    success = true,
                    score = score,
                    redirectUrl = Url.Action("Index", "Learning", new { courseId = courseId, itemId = itemId })
                });
            }
            catch (BusinessRuleException ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> SubmitAssignment(Guid itemId, string? textAnswer, IFormFile? file, string actionType)
        {
            try
            {
                var studentIdStr = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (!Guid.TryParse(studentIdStr, out Guid studentId))
                    return Json(new { success = false, message = "Please log in to continue." });

                if (actionType == "draft")
                {
                    await _learningService.SaveAssignmentDraftAsync(itemId, studentId, textAnswer, file);
                    return Json(new { success = true, message = "Draft saved successfully!" });
                }
                else
                {
                    await _learningService.SubmitAssignmentAsync(itemId, studentId, textAnswer, file);
                    return Json(new { success = true, message = "Assignment submitted successfully!" });
                }
            }
            catch (BusinessRuleException ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}