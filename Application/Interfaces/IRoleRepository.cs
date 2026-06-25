using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<PRole?> FindRoleByName(string roleName);
        Task<PRole?> FindRoleById(int id);
        Task<List<PRole>> GetListRoles(string? roleName, RoleStatus? status,
            int pageNumber, int pageSize);
        Task<int> Count(string? roleName, RoleStatus? status);
        Task Create(PRole role);
    }
}
