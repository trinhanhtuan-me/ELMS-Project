using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Identity
{
    public sealed record ForgotPasswordRequest(string Email);

    public sealed class VerifyForgotPasswordRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
    }

    public sealed class ResetPasswordRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public string NewPassword { get; set; }
    }

    public class ForgotPasswordRequestValidator : AbstractValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Please enter an email")
                .EmailAddress().WithMessage("PLease enter a valid email");
        }
    }

    public class VerifyForgotPasswordRequestValidator : AbstractValidator<VerifyForgotPasswordRequest>
    {
        public VerifyForgotPasswordRequestValidator()
        {
            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Please enter an email to reset password")
               .EmailAddress().WithMessage("PLease enter a valid email");
        }
    }
}
