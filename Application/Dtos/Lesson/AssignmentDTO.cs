using Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Application.Dtos.Lesson
{
    public class AssignmentCreateRequest
    {
        public Guid ModuleId { get; set; }
        public Guid CourseId { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string Instructions { get; set; } = string.Empty;

        public AssignmentSubmissionType SubmissionType { get; set; }

        public IFormFile? AttachmentFile { get; set; }

        public decimal MaxScore { get; set; } = 100;

        public decimal PassingScorePct { get; set; } = 50;
    }

    public class AssignmentUpdateRequest
    {
        public Guid ModuleItemId { get; set; }
        public Guid CourseId { get; set; }
        public Guid ModuleId { get; set; }
        public Guid ActualLessonId { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string Instructions { get; set; } = string.Empty;

        public AssignmentSubmissionType SubmissionType { get; set; }

        public IFormFile? AttachmentFile { get; set; }
        
        public string? CurrentAttachmentUrl { get; set; }

        public decimal MaxScore { get; set; } = 100;

        public decimal PassingScorePct { get; set; } = 50;
    }

    public class AssignmentCreateRequestValidator : AbstractValidator<AssignmentCreateRequest>
    {
        public AssignmentCreateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài tập");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung");
        }
    }

    public class AssignmentUpdateRequestValidator : AbstractValidator<AssignmentUpdateRequest>
    {
        public AssignmentUpdateRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vui lòng nhập tiêu đề bài tập");

            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("Vui lòng nhập nội dung");
        }
    }
}
