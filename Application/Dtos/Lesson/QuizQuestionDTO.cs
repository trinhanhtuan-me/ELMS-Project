using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Dtos.Lesson
{
    public class QuizQuestionOptionDto
    {
        public Guid? Id { get; set; }
        public string Content { get; set; } = null!;
        public bool IsCorrect { get; set; }
    }

    public class QuizQuestionDto
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        public List<QuizQuestionOptionDto> Options { get; set; } = new List<QuizQuestionOptionDto>();
    }

    public class QuizQuestionCreateRequest
    {
        public Guid QuizId { get; set; }
        public Guid CourseId { get; set; } // For permission check
        public Guid ModuleId { get; set; } // For routing back
        public Guid ModuleItemId { get; set; } // The module item id of the quiz

        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        public List<QuizQuestionOptionDto> Options { get; set; } = new List<QuizQuestionOptionDto>();
    }

    public class QuizQuestionUpdateRequest
    {
        public Guid QuestionId { get; set; }
        public Guid QuizId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ModuleItemId { get; set; }

        public string Content { get; set; } = null!;
        public string? Explanation { get; set; }
        public List<QuizQuestionOptionDto> Options { get; set; } = new List<QuizQuestionOptionDto>();
    }

    public class QuizQuestionCreateRequestValidator : AbstractValidator<QuizQuestionCreateRequest>
    {
        public QuizQuestionCreateRequestValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung câu hỏi");

            RuleFor(x => x.Options)
                .Must(opts => opts != null && opts.Count >= 2)
                .WithMessage("Câu hỏi phải có ít nhất 2 lựa chọn đáp án")
                .Must(opts => opts != null && opts.Any(o => o.IsCorrect))
                .WithMessage("Phải có ít nhất 1 đáp án đúng");

            RuleForEach(x => x.Options).ChildRules(option =>
            {
                option.RuleFor(x => x.Content).NotEmpty().WithMessage("Nội dung lựa chọn không được để trống");
            });
        }
    }

    public class QuizQuestionUpdateRequestValidator : AbstractValidator<QuizQuestionUpdateRequest>
    {
        public QuizQuestionUpdateRequestValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung câu hỏi");

            RuleFor(x => x.Options)
                .Must(opts => opts != null && opts.Count >= 2)
                .WithMessage("Câu hỏi phải có ít nhất 2 lựa chọn đáp án")
                .Must(opts => opts != null && opts.Any(o => o.IsCorrect))
                .WithMessage("Phải có ít nhất 1 đáp án đúng");

            RuleForEach(x => x.Options).ChildRules(option =>
            {
                option.RuleFor(x => x.Content).NotEmpty().WithMessage("Nội dung lựa chọn không được để trống");
            });
        }
    }
}
