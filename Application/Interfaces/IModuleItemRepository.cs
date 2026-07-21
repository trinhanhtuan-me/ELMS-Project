using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IModuleItemRepository
    {
        Task AddAsync(ModuleItem item);
        Task<ModuleItem?> GetByIdWithLessonAsync(Guid moduleItemId);
        Task<ModuleItem?> GetByIdWithAssignmentAsync(Guid moduleItemId);
        Task<ModuleItem?> GetByIdWithQuizAsync(Guid moduleItemId);
        Task<ModuleItem?> GetFullDetailByIdAsync(Guid id);
        Task<int> GetMaxOrderIndexAsync(Guid moduleId);
        Task<ModuleItem?> GetByIdAsync(Guid id);
        void Delete(ModuleItem item);
    }
}
