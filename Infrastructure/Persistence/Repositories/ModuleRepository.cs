using Application.Dtos.Learning;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
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

        public async Task<List<Module>> GetByCourseIdWithItemsAsync(Guid courseId)
        {
            return await _context.Modules
                .Include(m => m.ModuleItems)
                    .ThenInclude(mi => mi.Lesson)
                .Include(m => m.ModuleItems)
                    .ThenInclude(mi => mi.Assignment)
                .Include(m => m.ModuleItems)
                    .ThenInclude(mi => mi.Discussion)
                .Where(m => m.CourseId == courseId)
                .OrderBy(m => m.OrderIndex)
                .ToListAsync();
        }

        public async Task<ModuleItem?> GetVideoLessonAsync(Guid itemId)
        {
            return await _context.ModuleItems
                .Include(mi => mi.Lesson)
                    .ThenInclude(l => l.LessonQuestions)
                        .ThenInclude(q => q.LessonOptions)
                .FirstOrDefaultAsync(mi => mi.Id == itemId);
        }

        public async Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId)
        {
            var info = await _context.ModuleItems
                .Where(mi => mi.Id == itemId)
                .Select(mi => new
                {
                    ItemType = mi.ItemType,
                    ContentType = mi.Lesson != null ? (LessonContentType?)mi.Lesson.ContentType : null
                })
                .FirstOrDefaultAsync();
            if (info == null) return null;
            return (info.ItemType, info.ContentType);
        }
    }
}
