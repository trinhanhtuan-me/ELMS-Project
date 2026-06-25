using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class RoleRepository(ElmsDbContext _context) : IRoleRepository
    {

        public async Task Create(PRole role)
        {
            await _context.PRoles.AddAsync(role);
        }

        public async Task<PRole?> FindRoleById(int id)
        {
            return await _context.PRoles
                .Include(r => r.Functions).ThenInclude(f => f.Category)
                .FirstOrDefaultAsync(r => r.Id == id && !r.IsDeleted);
        }

        public async Task<PRole?> FindRoleByName(string roleName)
        {
            return await _context.PRoles.Include(r => r.Functions).FirstOrDefaultAsync(r => r.Name == roleName && !r.IsDeleted);
        }

        public async Task<List<PRole>> GetListRoles(string? roleName, RoleStatus? status, int pageNumber, int pageSize)
        {
            return await _context.PRoles
                .Where(r => string.IsNullOrEmpty(roleName) || r.Name.Contains(roleName))
                .Where(r => !status.HasValue || r.Status == status)
                .Include(r => r.Functions).ThenInclude(f => f.Category).AsSplitQuery()
                .OrderBy(r => r.Name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<int> Count(string? roleName, RoleStatus? status)
        {
            return await _context.PRoles
                .Where(r => string.IsNullOrEmpty(roleName) || r.Name.Contains(roleName))
                .Where(r => !status.HasValue || r.Status == status)
                .CountAsync();
        }



    }
}
