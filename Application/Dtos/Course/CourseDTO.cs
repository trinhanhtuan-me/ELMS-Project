using Domain.Entities;
using Domain.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using ModuleEntity = Domain.Entities.Module;

namespace Application.Dtos.Course
{
    public class CourseUpsertRequest
    {
        public Guid? Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string Language { get; set; } = null!;

        public string Level { get; set; } = null!;

        public int CategoryId { get; set; }

        public string? ThumbnailUrl { get; set; }

        public IFormFile? ThumbnailFile { get; set; }
    }


    public sealed record CourseManagementResponse(
        Guid Id,
        string Title,
        string Level,
        string Language,
        CourseStatus Status,
        string? Thumbnail,
        int CategoryId,
        string? Description,
        string? RejectReason
    );

  
    public sealed record CourseDetailResponse(
        Guid Id,
        string Title,
        string? Description,
        string? Thumbnail,
        List<ModuleEntity> Modules 
    );

    public class CoursePreviewViewModel
    {
        public CourseDetailResponse Course { get; set; } = null!;
        public ModuleItem? CurrentItem { get; set; }
    }

    public class CourseUpsertRequestValidator : AbstractValidator<CourseUpsertRequest>
    {
        public CourseUpsertRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(255).WithMessage("Title cannot exceed 255 characters");

            RuleFor(x => x.Language)
                .NotEmpty().WithMessage("Language is required");

            RuleFor(x => x.Level)
                .NotEmpty().WithMessage("Level is required");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("Category is required");
        }
    }
}
