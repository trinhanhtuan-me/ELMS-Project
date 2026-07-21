using System;
using FluentValidation;

namespace Application.Dtos.Lesson
{
    public class QuizCreateRequest
    {
        public Guid ModuleId { get; set; }
        public Guid CourseId { get; set; }
        
        public string Title { get; set; } = null!;
        public decimal PassingScorePct { get; set; } = 50;
        public int? PickCount { get; set; }
        public int? TimeLimitMin { get; set; }
        public int AttemptCooldownMin { get; set; }
    }

    public class QuizUpdateRequest
    {
        public Guid ModuleItemId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ActualLessonId { get; set; }

        public string Title { get; set; } = null!;
        public decimal PassingScorePct { get; set; } = 50;
        public int? PickCount { get; set; }
        public int? TimeLimitMin { get; set; }
        public int AttemptCooldownMin { get; set; }
    }

    public class QuizCreateRequestValidator : AbstractValidator<QuizCreateRequest>
    {
        public QuizCreateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài kiểm tra");
            
            RuleFor(x => x.PassingScorePct)
                .InclusiveBetween(0, 100).WithMessage("Điểm đạt phải từ 0 đến 100%");
                
            RuleFor(x => x.TimeLimitMin)
                .GreaterThan(0).When(x => x.TimeLimitMin.HasValue)
                .WithMessage("Thời gian làm bài phải lớn hơn 0");
                
            RuleFor(x => x.AttemptCooldownMin)
                .GreaterThanOrEqualTo(0).WithMessage("Thời gian chờ làm lại không được âm");
        }
    }

    public class QuizUpdateRequestValidator : AbstractValidator<QuizUpdateRequest>
    {
        public QuizUpdateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài kiểm tra");
            
            RuleFor(x => x.PassingScorePct)
                .InclusiveBetween(0, 100).WithMessage("Điểm đạt phải từ 0 đến 100%");
                
            RuleFor(x => x.TimeLimitMin)
                .GreaterThan(0).When(x => x.TimeLimitMin.HasValue)
                .WithMessage("Thời gian làm bài phải lớn hơn 0");
                
            RuleFor(x => x.AttemptCooldownMin)
                .GreaterThanOrEqualTo(0).WithMessage("Thời gian chờ làm lại không được âm");
        }
    }
}
