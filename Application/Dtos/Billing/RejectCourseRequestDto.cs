using FluentValidation;
using System;

namespace Application.Dtos.Billing;

public class RejectCourseRequestDto
{
    public Guid RequestId { get; set; }
    public string Note { get; set; } = null!;
}

public class RejectCourseRequestDtoValidator : AbstractValidator<RejectCourseRequestDto>
{
    public RejectCourseRequestDtoValidator()
    {
        RuleFor(x => x.RequestId)
            .NotEmpty().WithMessage("Mã yêu cầu không được để trống.");

        RuleFor(x => x.Note)
            .NotEmpty().WithMessage("Lý do từ chối không được để trống.")
            .MaximumLength(250).WithMessage("Lý do từ chối không được vượt quá 250 ký tự.");
    }
}
