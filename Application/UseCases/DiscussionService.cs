using Application.Common.Interfaces;
using Application.Dtos.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IDiscussionService
    {
        Task<Guid?> CreateDiscussionAsync(DiscussionCreateRequest request, Guid userId);
        Task<bool> UpdateDiscussionAsync(DiscussionUpdateRequest request, Guid userId);
        Task<DiscussionUpdateRequest?> GetDiscussionForUpdateAsync(Guid lessonId);
    }

    public class DiscussionService : IDiscussionService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _uow;

        public DiscussionService(
            IModuleRepository moduleRepository,
            IModuleItemRepository moduleItemRepository,
            ICourseRepository courseRepository,
            IUnitOfWork uow)
        {
            _moduleRepository = moduleRepository;
            _moduleItemRepository = moduleItemRepository;
            _courseRepository = courseRepository;
            _uow = uow;
        }

        public async Task<Guid?> CreateDiscussionAsync(DiscussionCreateRequest request, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(request.ModuleId);
            if (module == null) return null;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return null;

            var maxOrder = await _moduleItemRepository.GetMaxOrderIndexAsync(request.ModuleId);

            var moduleItem = new ModuleItem
            {
                ModuleId = request.ModuleId,
                ItemType = ModuleItemType.Discussion,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            moduleItem.Discussion = new Discussion
            {
                Title = request.Title,
                Description = request.Description
            };

            await _moduleItemRepository.AddAsync(moduleItem);
            await _uow.SaveChangeAsync();

            return moduleItem.Id;
        }

        public async Task<bool> UpdateDiscussionAsync(DiscussionUpdateRequest request, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithDiscussionAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Discussion == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            moduleItem.Discussion.Title = request.Title;
            moduleItem.Discussion.Description = request.Description;

            moduleItem.UpdatedAt = DateTime.UtcNow;
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<DiscussionUpdateRequest?> GetDiscussionForUpdateAsync(Guid lessonId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithDiscussionAsync(lessonId);
            if (moduleItem == null || moduleItem.Discussion == null || moduleItem.Module == null) return null;

            return new DiscussionUpdateRequest
            {
                ModuleItemId = lessonId,
                CourseId = moduleItem.Module.CourseId,
                ModuleId = moduleItem.ModuleId,
                ActualLessonId = moduleItem.Discussion.Id,
                Title = moduleItem.Discussion.Title,
                Description = moduleItem.Discussion.Description
            };
        }
    }
}
