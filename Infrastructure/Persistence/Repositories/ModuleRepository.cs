using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly ElmsDbContext _context;

        public ModuleRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<List<Module>> GetByCourseIdAsync(Guid courseId)
        {
            return await _context.Modules
                .Where(m => m.CourseId == courseId)
                .OrderBy(m => m.OrderIndex)
                .ToListAsync();
        }

        public async Task<Module?> GetByIdAsync(Guid id)
        {
            return await _context.Modules.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddAsync(Module module)
        {
            await _context.Modules.AddAsync(module);
        }

        public void Update(Module module)
        {
            _context.Modules.Update(module);
        }

        public void Delete(Module module)
        {
            _context.Modules.Remove(module);
        }

        public async Task<int> GetMaxOrderIndexAsync(Guid courseId)
        {
            var modules = await _context.Modules.Where(m => m.CourseId == courseId).ToListAsync();
            if (!modules.Any()) return 0;
            return modules.Max(m => m.OrderIndex);
        }
    }
}
