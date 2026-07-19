using FluentValidation;
using System;
using System.Collections.Generic;

namespace Application.Dtos.Billing;

public class InitiatePaymentRequestDto
{
    public List<Guid> RequestIds { get; set; } = new();
}

public class InitiatePaymentRequestDtoValidator : AbstractValidator<InitiatePaymentRequestDto>
{
    public InitiatePaymentRequestDtoValidator()
    {
        RuleFor(x => x.RequestIds)
            .NotEmpty().WithMessage("Vui lòng chọn ít nhất một khóa học để thanh toán.");
    }
}
