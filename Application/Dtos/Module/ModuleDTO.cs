using FluentValidation;
using System;

namespace Application.Dtos.Module
{
    public sealed record ModuleRequest(
        Guid? Id,
        Guid CourseId,
        string Title,
        string? Description
    );

    public class ModuleUpsertRequestValidator : AbstractValidator<ModuleRequest>
    {
        public ModuleUpsertRequestValidator()
        {
            RuleFor(x => x.CourseId).NotEmpty().WithMessage("CourseId is required");
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(255).WithMessage("Title cannot exceed 255 characters");
        }
    }
}
