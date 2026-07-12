using Domain.Enums;
using Domain.Entities;
using FluentValidation;
using ModuleEntity = Domain.Entities.Module;
using System;

namespace Application.Dtos.Course
{
    public sealed record CourseUpsertRequest(
         Guid? Id,
         string Title,
         string? Description,
         string Language,
         string Level,
         int CategoryId
     );

   
    public sealed record CourseManagementResponse(
        Guid Id,
        string Title,
        string Level,
        string Language,
        CourseStatus Status,
        string? Thumbnail,
        int CategoryId,
        string? Description
    );

  
    public sealed record CourseDetailResponse(
        Guid Id,
        string Title,
        string? Description,
        string? Thumbnail,
        List<ModuleEntity> Modules 
    );

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
