using Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Role
{
    public sealed record GetListRoleRequest(string? RoleName, RoleStatus? Status,
        int PageNumber = 1, int PageSize = 10);

    public class GetListRoleRequestValidator : AbstractValidator<GetListRoleRequest>
    {
        public GetListRoleRequestValidator()
        {
            RuleFor(x => x.Status).IsInEnum()
                .WithMessage("Role status is invalid").When(x => x.Status.HasValue);
        }
    }

    public sealed record RoleVm(
        int RoleId, string RoleName,
        string RoleDescription, RoleStatus Status,
        List<FunctionCategoryInfoVm> FunctionCategories
        );

    public sealed record FunctionCategoryInfoVm(
        int CategoryId,
        string CategoryDecription,
        List<FunctionDetailVm> Functions
        );

    public sealed record FunctionDetailVm(
        int FunctionId,
        string FunctionDescription
        );
}
