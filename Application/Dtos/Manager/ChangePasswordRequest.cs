using FluentValidation;

namespace Application.Dtos.Manager
{
    public class ChangePasswordRequest
    {
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator()
        {
            RuleFor(x => x.CurrentPassword)
                .NotEmpty().WithMessage("Please enter your current password.");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Please enter your new password.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$")
                .WithMessage("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.NewPassword)
                .WithMessage("Passwords do not match!");
        }
    }
}
