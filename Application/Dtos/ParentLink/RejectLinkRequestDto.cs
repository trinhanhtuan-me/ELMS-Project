using FluentValidation;
using System;

namespace Application.Dtos.ParentLink;

public class RejectLinkRequestDto
{
    public Guid RequestId { get; set; }
    public string Note { get; set; } = null!;
}

public class RejectLinkRequestDtoValidator : AbstractValidator<RejectLinkRequestDto>
{
    public RejectLinkRequestDtoValidator()
    {
        RuleFor(x => x.RequestId)
            .NotEmpty().WithMessage("Mã yêu cầu không được để trống.");

        RuleFor(x => x.Note)
            .NotEmpty().WithMessage("Lý do từ chối không được để trống.")
            .MaximumLength(500).WithMessage("Lý do từ chối không được vượt quá 500 ký tự.");
    }
}
