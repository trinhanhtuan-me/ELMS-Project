using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseReview
{
    public sealed record CreateReviewRequest(Guid CourseId, int Rating, string Comment);

    public class CreateReviewRequestValidator : AbstractValidator<CreateReviewRequest>
    {
        public CreateReviewRequestValidator()
        {
            RuleFor(x => x.CourseId)
                .NotEmpty().WithMessage("CourseId is required.");

            RuleFor(x => x.Rating)
                .InclusiveBetween(1, 5).WithMessage("Rating must be between 1 and 5.");

            RuleFor(x => x.Comment)
                .NotEmpty().WithMessage("Comment is required.")
                .MaximumLength(1000).WithMessage("Comment must not exceed 1000 characters.");
        }
    }
}
