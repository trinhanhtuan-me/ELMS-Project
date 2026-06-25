using Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Role
{
    public sealed record UpdateRoleRequest(int RoleId, string Name,
        RoleStatus Status, string? Description,
        IEnumerable<int> FunctionIds);

    public class UpdateRoleRequestValidator : AbstractValidator<UpdateRoleRequest>
    {
        public UpdateRoleRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role name is required")
                .MaximumLength(100).WithMessage("Role name must be less than 100 characters");

            RuleFor(x => x.Description)
                .MaximumLength(300).WithMessage("Role description cannot exceed 300 characters")
                .When(x => !string.IsNullOrEmpty(x.Description));

            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Please choose valid role status");

            RuleFor(x => x.FunctionIds)
                .NotEmpty().WithMessage("Please choose at least 1 function for this role");

        }
    }
}
