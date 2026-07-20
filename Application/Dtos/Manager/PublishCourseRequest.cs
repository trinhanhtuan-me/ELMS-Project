using FluentValidation;
using System;

namespace Application.Dtos.Manager
{
    public class PublishCourseRequest
    {
        public Guid CourseId { get; set; }
        public DateTime? PublishDate { get; set; }
        public decimal Price { get; set; }
    }

    public class PublishCourseRequestValidator : AbstractValidator<PublishCourseRequest>
    {
        public PublishCourseRequestValidator()
        {
            RuleFor(x => x.CourseId)
                .NotEmpty().WithMessage("User id is empty.");

            RuleFor(x => x.PublishDate)
                .NotEmpty().WithMessage("Selected publishdate.")
                .GreaterThanOrEqualTo(DateTime.Today).WithMessage("publishdate can't be in a past!");

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Price need to be larger than 0VNĐ.")
                .LessThan(100000000).WithMessage("Max price is 100,000,000 VNĐ.");
        }
    }
}
