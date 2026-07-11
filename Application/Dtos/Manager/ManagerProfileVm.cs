using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;

namespace Application.Dtos.Manager;

public class ManagerProfileVm
{
    public Guid UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? AvatarUrl { get; set; }

    public IFormFile? AvatarFile { get; set; }

    public string? Position { get; set; }

    public string? Specialization { get; set; }
}

public class ManagerProfileVmValidator : AbstractValidator<ManagerProfileVm>
{
    public ManagerProfileVmValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("Full Name cannot be empty.")
            .MaximumLength(100).WithMessage("Full Name must not exceed 100 characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email cannot be empty.")
            .EmailAddress().WithMessage("Invalid email format.")
            .MaximumLength(255).WithMessage("Email must not exceed 255 characters.");

        RuleFor(x => x.Position)
            .MaximumLength(100).WithMessage("Position must not exceed 100 characters.");

        RuleFor(x => x.Specialization)
            .MaximumLength(255).WithMessage("Specialization must not exceed 255 characters.");

        RuleFor(x => x.DateOfBirth)
            .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
            .WithMessage("Date of Birth cannot be in the future.")
            .When(x => x.DateOfBirth.HasValue);
    }
}
