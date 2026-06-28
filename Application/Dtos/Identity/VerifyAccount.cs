using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Identity
{
    public record VerifyAccountRequest(string Email, string OtpCode);

    public class VerifyAccountRequestValidation : AbstractValidator<VerifyAccountRequest>
    {
        public VerifyAccountRequestValidation()
        {
            RuleFor(x => x.OtpCode)
                .NotEmpty().WithMessage("OTP code is required.")
                .Length(6).WithMessage("OTP code must be exactly 6 digits.")
                .Matches("^[0-9]*$").WithMessage("OTP code must contain only numbers.");
        }
    }
}
