using Application.Common.Interfaces;
using Application.Dtos.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IQuizService
    {
        Task<Guid?> CreateQuizAsync(QuizCreateRequest request, Guid userId);
        Task<bool> UpdateQuizAsync(QuizUpdateRequest request, Guid userId);
        Task<QuizUpdateRequest?> GetQuizForUpdateAsync(Guid lessonId);
        Task<bool> DeleteQuizAsync(Guid moduleItemId, Guid courseId, Guid userId);
    }

    public class QuizService : IQuizService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _uow;

        public QuizService(
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

        public async Task<Guid?> CreateQuizAsync(QuizCreateRequest request, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(request.ModuleId);
            if (module == null) return null;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return null;

            var maxOrder = await _moduleItemRepository.GetMaxOrderIndexAsync(request.ModuleId);

            var moduleItem = new ModuleItem
            {
                ModuleId = request.ModuleId,
                ItemType = ModuleItemType.Quiz,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            moduleItem.Quiz = new Quiz
            {
                Title = request.Title,
                PassingScorePct = request.PassingScorePct,
                PickCount = request.PickCount,
                TimeLimitMin = request.TimeLimitMin,
                AttemptCooldownMin = request.AttemptCooldownMin
            };

            await _moduleItemRepository.AddAsync(moduleItem);
            await _uow.SaveChangeAsync();

            return moduleItem.Id;
        }

        public async Task<bool> UpdateQuizAsync(QuizUpdateRequest request, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithQuizAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Quiz == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            moduleItem.Quiz.Title = request.Title;
            moduleItem.Quiz.PassingScorePct = request.PassingScorePct;
            moduleItem.Quiz.PickCount = request.PickCount;
            moduleItem.Quiz.TimeLimitMin = request.TimeLimitMin;
            moduleItem.Quiz.AttemptCooldownMin = request.AttemptCooldownMin;

            moduleItem.UpdatedAt = DateTime.UtcNow;

            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<QuizUpdateRequest?> GetQuizForUpdateAsync(Guid lessonId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithQuizAsync(lessonId);
            if (moduleItem == null || moduleItem.Quiz == null) return null;

            return new QuizUpdateRequest
            {
                ModuleItemId = moduleItem.Id,
                CourseId = moduleItem.Module.CourseId,
                ModuleId = moduleItem.ModuleId,
                ActualLessonId = moduleItem.Quiz.Id,
                Title = moduleItem.Quiz.Title,
                PassingScorePct = moduleItem.Quiz.PassingScorePct,
                PickCount = moduleItem.Quiz.PickCount,
                TimeLimitMin = moduleItem.Quiz.TimeLimitMin,
                AttemptCooldownMin = moduleItem.Quiz.AttemptCooldownMin
            };
        }

        public async Task<bool> DeleteQuizAsync(Guid moduleItemId, Guid courseId, Guid userId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course == null || course.CreatedBy != userId) return false;

            var moduleItem = await _moduleItemRepository.GetByIdAsync(moduleItemId);
            if (moduleItem == null || moduleItem.ItemType != ModuleItemType.Quiz) return false;

            _moduleItemRepository.Delete(moduleItem);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}
