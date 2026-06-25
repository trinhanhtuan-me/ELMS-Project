using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Identity
{
    public sealed record LoginRequest(string Identifier, string Password);

    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Identifier)
                .NotEmpty().WithMessage("Account name is required")
                .MinimumLength(5).WithMessage("Login must be at least 5 characters long.");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{6,}$")
                .WithMessage("Password must be at least 6 characters long and contain at least " +
                "one uppercase letter, one lowercase letter, one number, and one special character.");
        }
    }
}
