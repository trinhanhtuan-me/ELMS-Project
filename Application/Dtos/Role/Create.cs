using FluentValidation;


namespace Application.Dtos.Role
{
    public sealed record CreateRoleRequest(string Name,
        string Description, IEnumerable<int> FunctionIds);

    public class CreateRoleRequestValidator : AbstractValidator<CreateRoleRequest>
    {
        public CreateRoleRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role name is required")
                .MaximumLength(100).WithMessage("Role name must be less than 100 characters");

            RuleFor(x => x.Description)
                .MaximumLength(300).WithMessage("Role description cannot exceed 300 characters");

            RuleFor(x => x.FunctionIds)
                .NotEmpty().WithMessage("Please choose at least 1 function for this role");
        }
    }
}
