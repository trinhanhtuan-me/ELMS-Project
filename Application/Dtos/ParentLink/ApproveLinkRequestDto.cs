using FluentValidation;
using System;

namespace Application.Dtos.ParentLink;

public class ApproveLinkRequestDto
{
    public Guid RequestId { get; set; }
    public string? Note { get; set; }
}

public class ApproveLinkRequestDtoValidator : AbstractValidator<ApproveLinkRequestDto>
{
    public ApproveLinkRequestDtoValidator()
    {
        RuleFor(x => x.RequestId)
            .NotEmpty().WithMessage("Mã yêu cầu không được để trống.");
    }
}
