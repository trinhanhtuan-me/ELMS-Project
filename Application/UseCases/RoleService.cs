using Application.Common;
using Application.Common.Interfaces;
using Application.Dtos.Role;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IRoleService
    {
        Task Create(CreateRoleRequest request);
        Task Update(UpdateRoleRequest request);
        Task Delete(DeleteRoleRequest request);
        Task<PaginatedList<RoleVm>> GetList(GetListRoleRequest request);
        Task<UpdateRoleRequest> GetRoleForEdit(int roleId);
    }

    public class RoleService : IRoleService
    {
        private IFunctionRepository _function;
        private IRoleRepository _role;
        private IUnitOfWork _uow;

        public RoleService(IFunctionRepository function, IRoleRepository role, IUnitOfWork unitOfWork)
        {
            _function = function;
            _role = role;
            _uow = unitOfWork;
        }

        public async Task Create(CreateRoleRequest request)
        {
            var findRoleResult = await _role.FindRoleByName(request.Name);
            if (findRoleResult != null) throw new BusinessRuleException("Role name is existed");

            var listFunction = await _function.FindFunctionsByIds(request.FunctionIds);
            var newRole = new PRole
            {
                Name = request.Name,
                Description = request.Description,
                Functions = listFunction.ToList(),
                IsDeleted = false
            };

            await _role.Create(newRole);
            await _uow.SaveChangeAsync();
        }


        public async Task Update(UpdateRoleRequest request)
        {
            var foundRole = await _role.FindRoleById(request.RoleId);
            if (foundRole == null) throw new BusinessRuleException("Can not find this role");

            var findByNameResult = await _role.FindRoleByName(request.Name);
            if (findByNameResult != null && findByNameResult.Id != request.RoleId) throw new BusinessRuleException("Role name is existed");

            var listFunction = await _function.FindFunctionsByIds(request.FunctionIds);

            foundRole.Name = request.Name;
            foundRole.Description = request.Description;
            foundRole.Status = request.Status;
            foundRole.Functions = listFunction.ToList();

            await _uow.SaveChangeAsync();
        }

        public async Task Delete(DeleteRoleRequest request)
        {
            var foundRole = await _role.FindRoleById(request.RoleId);
            if (foundRole == null) throw new BusinessRuleException("Can not find this role");

            foundRole.IsDeleted = true;
            await _uow.SaveChangeAsync();
        }

        public async Task<PaginatedList<RoleVm>> GetList(GetListRoleRequest request)
        {
            var pageNumber = request.PageNumber <= 0 ? 1 : request.PageNumber;
            var pageSize = request.PageSize <= 0 ? 10 : request.PageSize;
            if (pageSize > 100) pageSize = 100;

            var findRole = await _role.GetListRoles(request.RoleName, request.Status,
                                       pageNumber, request.PageSize);

            int count = await _role.Count(request.RoleName, request.Status);

            var result = findRole.Select(r => new RoleVm(
                    RoleId: r.Id,
                    RoleName: r.Name,
                    RoleDescription: r.Description ?? string.Empty,
                    Status: r.Status,
                    FunctionCategories: r.Functions
                    .GroupBy(f => f.Category)
                    .Select(group => new FunctionCategoryInfoVm
                    (
                        CategoryId: group.Key.Id,
                        CategoryDecription: group.Key.Description,
                        Functions: group.Select(f => new FunctionDetailVm(
                            FunctionId: f.Id,
                            FunctionDescription: f.Description ?? string.Empty
                            )).ToList()
                    )).ToList()
                )).ToList();

            return new PaginatedList<RoleVm>(count, result);
        }

        public async Task<UpdateRoleRequest> GetRoleForEdit(int roleId)
        {
            var role = await _role.FindRoleById(roleId);
            if (role == null) throw new BusinessRuleException("Can not find this role");

            var result = new UpdateRoleRequest(roleId, role.Name,
                 role.Status, role.Description,
                 role.Functions.Select(f => f.Id).ToList());
            return result;
        }

    }
}
