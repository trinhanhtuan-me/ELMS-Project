using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ModuleItemRepository : IModuleItemRepository
    {
        private readonly ElmsDbContext _context;

        public ModuleItemRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ModuleItem item)
        {
            await _context.ModuleItems.AddAsync(item);
        }

        public async Task<int> GetMaxOrderIndexAsync(Guid moduleId)
        {
            var items = await _context.ModuleItems.Where(m => m.ModuleId == moduleId).ToListAsync();
            if (!items.Any()) return 0;
            return items.Max(m => m.OrderIndex);
        }

        public async Task<ModuleItem?> GetByIdAsync(Guid id)
        {
            return await _context.ModuleItems.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ModuleItem?> GetByIdWithLessonAsync(Guid id)
        {
            return await _context.ModuleItems
                .Include(m => m.Lesson)
                .Include(m => m.Module)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ModuleItem?> GetByIdWithAssignmentAsync(Guid id)
        {
            return await _context.ModuleItems
                .Include(m => m.Assignment)
                .Include(m => m.Module)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ModuleItem?> GetByIdWithDiscussionAsync(Guid id)
        {
            return await _context.ModuleItems
                .Include(m => m.Discussion)
                .Include(m => m.Module)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public void Delete(ModuleItem item)
        {
            _context.ModuleItems.Remove(item);
        }
    }
}
