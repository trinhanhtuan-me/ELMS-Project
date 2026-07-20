using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Application.Dtos.Lesson
{
    public class DiscussionCreateRequest
    {
        public Guid ModuleId { get; set; }
        public Guid CourseId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }
    }

    public class DiscussionUpdateRequest
    {
        public Guid ModuleItemId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ActualLessonId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }
    }

    public class DiscussionCreateRequestValidator : AbstractValidator<DiscussionCreateRequest>
    {
        public DiscussionCreateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề thảo luận");
        }
    }

    public class DiscussionUpdateRequestValidator : AbstractValidator<DiscussionUpdateRequest>
    {
        public DiscussionUpdateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề thảo luận");
        }
    }
}
