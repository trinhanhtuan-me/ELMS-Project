using Application.Dtos.Lesson;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuestionApiController : ControllerBase
    {
        private readonly IQuizQuestionService _service;

        public QuizQuestionApiController(IQuizQuestionService service)
        {
            _service = service;
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

        [HttpGet("quiz/{quizId}")]
        public async Task<IActionResult> GetQuestions(Guid quizId)
        {
            var userId = GetUserId();
            var questions = await _service.GetQuestionsByQuizIdAsync(quizId, userId);
            return Ok(questions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(Guid id)
        {
            var userId = GetUserId();
            var question = await _service.GetQuestionForUpdateAsync(id, userId);
            if (question == null) return NotFound();
            return Ok(question);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion([FromBody] QuizQuestionCreateRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var userId = GetUserId();
                var success = await _service.CreateQuestionAsync(request, userId);
                if (!success) return BadRequest(new { message = "Failed to create question. Ensure you have permission and provided valid options." });

                return Ok(new { message = "Question created successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestion(Guid id, [FromBody] QuizQuestionUpdateRequest request)
        {
            if (id != request.QuestionId) return BadRequest(new { message = "ID mismatch" });
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var userId = GetUserId();
                var success = await _service.UpdateQuestionAsync(request, userId);
                if (!success) return BadRequest(new { message = "Failed to update question. Ensure you have permission and provided valid options." });

                return Ok(new { message = "Question updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(Guid id, [FromQuery] Guid quizId)
        {
            try
            {
                var userId = GetUserId();
                var success = await _service.DeleteQuestionAsync(id, quizId, userId);
                if (!success) return NotFound();

                return Ok(new { message = "Question deleted successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
