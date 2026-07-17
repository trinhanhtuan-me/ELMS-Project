using Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseRequest
{
    public sealed record GetListCourseRequest(string? Keyword, CourseRequestStatus? Status, string? SortBy,
        int PageNumber = 1, int PageSize = 10);

    public class GetListCourseRequestValidator : AbstractValidator<GetListCourseRequest>
    {
        public GetListCourseRequestValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Page number must be greater than or equal to 1.");
            RuleFor(x => x.PageSize)
                .InclusiveBetween(1, 100)
                .WithMessage("Page size must be between 1 and 100.");
            RuleFor(x => x.Keyword)
                .MaximumLength(100)
                .WithMessage("Keyword must not exceed 100 characters.")
                .When(x => !string.IsNullOrWhiteSpace(x.Keyword));
            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("Invalid status value.")
                .When(x => x.Status.HasValue);
        }
    }

    public sealed record GetListCourseRequestVm(Guid Id, string Title, CourseRequestStatus Status, string? Note);
}
