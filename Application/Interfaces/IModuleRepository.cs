using Application.Dtos.Learning;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IModuleRepository
    {
        Task<List<Module>> GetByCourseIdAsync(Guid courseId);
        Task<Module?> GetByIdAsync(Guid id);
        Task AddAsync(Module module);
        void Update(Module module);
        void Delete(Module module);
        Task<int> GetMaxOrderIndexAsync(Guid courseId);
        Task<List<Module>> GetByCourseIdWithItemsAsync(Guid courseId);
        Task<ModuleItem?> GetVideoLessonAsync(Guid itemId);
        Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId);
    }
}