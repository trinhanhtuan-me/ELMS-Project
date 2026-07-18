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
                return View();
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
            try {
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
                            //var readingContent = await _learningService.GetReadingLessonAsync(itemId);
                            //return PartialView("_ReadingLesson", readingContent);
                        }
                        break;

                    case ModuleItemType.Quiz:
                        // var quizContent = await _learningService.GetQuizAsync(itemId);
                        // return PartialView("_QuizForm", quizContent);
                        break;

                    case ModuleItemType.Assignment:
                        // var assignmentContent = await _learningService.GetAssignmentAsync(itemId);
                        // return PartialView("_AssignmentForm", assignmentContent);
                        break;
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
    }
}
