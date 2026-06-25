using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiggyCreatures.Caching.Fusion;

namespace Infrastructure.Persistence.Repositories
{

    public class CacheFunctionRepository(
        IFusionCache cache,
        [FromKeyedServices("original")] IFunctionRepository repository
        ) : IFunctionRepository
    {
        public async Task<IEnumerable<PFunction>> FindFunctionsByIds(IEnumerable<int> ids)
        {
            return await repository.FindFunctionsByIds(ids);
        }

        public async Task<IEnumerable<PFunction>> FindUserFunctions(Guid userId)
        {
            return await cache.GetOrSetAsync<IEnumerable<PFunction>>(
                key: $"UserFunctions_{userId}",
                factory: async (ctx, _) =>
                {
                    var result = await repository.FindUserFunctions(userId);
                    return result;
                },
                duration: TimeSpan.FromMinutes(10)
                ) ?? new List<PFunction>();
        }

        public async Task<IEnumerable<PFunction>> GetAllFunctions()
        {
            return await cache.GetOrSetAsync<IEnumerable<PFunction>>(
                key: "AllFunctions",
                factory: async (ctx, _) =>
                {
                    return await repository.GetAllFunctions();
                },
                duration: TimeSpan.FromMinutes(15)
                ) ?? new List<PFunction>();
        }
    }
    public class FunctionRepository(ElmsDbContext _context) : IFunctionRepository
    {
        public async Task<IEnumerable<PFunction>> FindFunctionsByIds(IEnumerable<int> ids)
        {
            return await _context.PFunctions
                .Where(f => ids.Contains(f.Id) && !f.IsDeleted)
                .ToListAsync();
        }

        public async Task<IEnumerable<PFunction>> FindUserFunctions(Guid userId)
        {
            var userFunctions = await _context.Users
               .Where(u => u.Id == userId && !u.IsDeleted)
               .SelectMany(u => u.Roles).Where(r => r.Status == RoleStatus.Active && !r.IsDeleted)
               .SelectMany(r => r.Functions).Where(f => !f.IsDeleted)
               .Distinct()
               .ToListAsync();
            return userFunctions;
        }

        public async Task<IEnumerable<PFunction>> GetAllFunctions()
        {
            return await _context.PFunctions
                .Include(p => p.Category)
                .Where(f => !f.IsDeleted)
                .ToListAsync();
        }
    }
}
