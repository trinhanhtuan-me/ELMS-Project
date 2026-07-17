using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Lesson
{
    public class LessonQuestionDto
    {
        public Guid Id { get; set; }
        public Guid LessonId { get; set; }
        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        public List<LessonOptionDto> Options { get; set; } = new List<LessonOptionDto>();
    }

    public class LessonOptionDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public bool IsCorrect { get; set; }
    }

    public class LessonQuestionCreateRequest
    {
        [Required]
        public Guid LessonId { get; set; }
        [Required]
        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = "A question must have at least 2 options.")]
        public List<LessonOptionCreateRequest> Options { get; set; } = new List<LessonOptionCreateRequest>();
    }

    public class LessonQuestionUpdateRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = "A question must have at least 2 options.")]
        public List<LessonOptionCreateRequest> Options { get; set; } = new List<LessonOptionCreateRequest>();
    }

    public class LessonOptionCreateRequest
    {
        [Required]
        public string Content { get; set; } = null!;
        public bool IsCorrect { get; set; }
    }
}
