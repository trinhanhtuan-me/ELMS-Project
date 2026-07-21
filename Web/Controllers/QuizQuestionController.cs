using Application.Dtos.Lesson;
using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    public class QuizQuestionController : Controller
    {
        private readonly IQuizQuestionService _quizQuestionService;

        public QuizQuestionController(IQuizQuestionService quizQuestionService)
        {
            _quizQuestionService = quizQuestionService;
        }

        private Guid GetUserId()
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out var userId))
            {
                throw new UnauthorizedAccessException("User ID is not found or invalid.");
            }
            return userId;
        }

        [HttpGet]
        public IActionResult Index(Guid quizId, Guid courseId, Guid moduleId, Guid moduleItemId)
        {
            ViewBag.QuizId = quizId;
            ViewBag.CourseId = courseId;
            ViewBag.ModuleId = moduleId;
            ViewBag.ModuleItemId = moduleItemId;

            return View();
        }
    }
}
