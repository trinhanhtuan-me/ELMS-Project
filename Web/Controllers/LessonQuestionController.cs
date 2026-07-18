using Application.Dtos.Lesson;
using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LessonQuestionController : ControllerBase
    {
        private readonly ILessonQuestionService _service;

        public LessonQuestionController(ILessonQuestionService service)
        {
            _service = service;
        }

        [HttpGet("lesson/{lessonId}")]
        public async Task<IActionResult> GetQuestions(Guid lessonId)
        {
            var questions = await _service.GetQuestionsByLessonIdAsync(lessonId);
            return Ok(questions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(Guid id)
        {
            var question = await _service.GetQuestionByIdAsync(id);
            if (question == null) return NotFound();
            return Ok(question);
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion([FromBody] LessonQuestionCreateRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var success = await _service.CreateQuestionAsync(request);
            if (!success) return BadRequest(new { message = "Failed to create question. Ensure there are at least 2 options and 1 correct option." });

            return Ok(new { message = "Question created successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuestion(Guid id, [FromBody] LessonQuestionUpdateRequest request)
        {
            if (id != request.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var success = await _service.UpdateQuestionAsync(request);
            if (!success) return BadRequest(new { message = "Failed to update question. Ensure there are at least 2 options and 1 correct option." });

            return Ok(new { message = "Question updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(Guid id)
        {
            var success = await _service.DeleteQuestionAsync(id);
            if (!success) return NotFound();

            return Ok(new { message = "Question deleted successfully" });
        }
    }
}
