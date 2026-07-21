using Application.Common.Interfaces;
using Application.Dtos.Module;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IModuleService
    {
        Task<List<Module>> GetModulesByCourseAsync(Guid courseId);
        Task<List<Module>> GetModulesWithItemsAsync(Guid courseId);
        Task<bool> CreateModuleAsync(ModuleRequest request, Guid userId);
        Task<bool> UpdateModuleAsync(ModuleRequest request, Guid userId);
        Task<bool> DeleteModuleAsync(Guid id, Guid userId);
        Task<ModuleItem?> GetModuleItemFullDetailByIdAsync(Guid itemId);
    }

    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly IUnitOfWork _uow;

        public ModuleService(IModuleRepository moduleRepository, ICourseRepository courseRepository, IModuleItemRepository moduleItemRepository, IUnitOfWork uow)
        {
            _moduleRepository = moduleRepository;
            _courseRepository = courseRepository;
            _moduleItemRepository = moduleItemRepository;
            _uow = uow;
        }

        public async Task<List<Module>> GetModulesByCourseAsync(Guid courseId)
        {
            return await _moduleRepository.GetByCourseIdAsync(courseId);
        }

        public async Task<List<Module>> GetModulesWithItemsAsync(Guid courseId)
        {
            return await _moduleRepository.GetByCourseIdWithItemsAsync(courseId);
        }

        public async Task<ModuleItem?> GetModuleItemFullDetailByIdAsync(Guid itemId)
        {
            return await _moduleItemRepository.GetFullDetailByIdAsync(itemId);
        }

        public async Task<bool> CreateModuleAsync(ModuleRequest request, Guid userId)
        {
            var course = await _courseRepository.GetByIdAsync(request.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            var maxOrder = await _moduleRepository.GetMaxOrderIndexAsync(request.CourseId);

            var module = new Module
            {
                CourseId = request.CourseId,
                Title = request.Title,
                Description = request.Description,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            await _moduleRepository.AddAsync(module);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> UpdateModuleAsync(ModuleRequest request, Guid userId)
        {
            if (request.Id == null) return false;

            var module = await _moduleRepository.GetByIdAsync(request.Id.Value);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            module.Title = request.Title;
            module.Description = request.Description;
            module.UpdatedAt = DateTime.UtcNow;
            module.UpdatedBy = userId;

            _moduleRepository.Update(module);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> DeleteModuleAsync(Guid id, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(id);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            _moduleRepository.Delete(module);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}