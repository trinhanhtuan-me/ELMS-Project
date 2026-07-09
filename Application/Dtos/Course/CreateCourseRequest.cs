using FluentValidation;

namespace Application.Dtos.Course
{
    public sealed record CreateCourseRequest(
        string Title,
        string? Description,
        string Language,
        string Level,
        int CategoryId
    );

    public class CreateCourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseRequestValidator()
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
