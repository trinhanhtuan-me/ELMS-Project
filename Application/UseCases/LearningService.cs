using Application.Common.Interfaces;
using Application.Dtos.Learning;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ILearningService
    {
        Task<LearningSyllabusDto?> GetCourseSyllabusAsync(Guid courseId, Guid studentId);
        Task<VideoLessonDto?> GetVideoLessonAsync(Guid itemId, Guid studentId);
        Task SubmitLessonQuestionAsync(Guid studentId, SubmitLessonQuestionRequest request);
        Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId);

    }

    public class LearningService : ILearningService
    {
        private readonly IUnitOfWork _uow;
        private readonly ICourseRepository _course;
        private readonly IModuleRepository _module;
        private readonly IProgressRepository _progress;

        public LearningService(IUnitOfWork uow, ICourseRepository course, IModuleRepository module, IProgressRepository progress)
        {
            _uow = uow;
            _course = course;
            _module = module;
            _progress = progress;
        }

        public async Task<LearningSyllabusDto?> GetCourseSyllabusAsync(Guid courseId, Guid studentId)
        {
            var course = await _course.GetSyllabusForStudentAsync(courseId, studentId);
            if (course == null) throw new BusinessRuleException("Coure not found");

            var result = new LearningSyllabusDto(
                course.Id,
                course.Title,
                course.Modules.OrderBy(m => m.OrderIndex).Select(m => new ModuleSyllabusDto(
                    m.Id,
                    m.Title,
                    m.OrderIndex,
                    m.ModuleItems.OrderBy(mi => mi.OrderIndex).Select(mi => new ItemSyllabusDto(
                        mi.Id,
                        GetItemTitle(mi),
                        mi.ItemType,
                        mi.OrderIndex,
                        mi.Progresses.Any(p => p.Status == ProgressStatus.Completed)
                    )).ToList()
                )).ToList()
            );
            return result;
        }

        private string GetItemTitle(ModuleItem mi)
        {
            return mi.ItemType switch
            {
                ModuleItemType.Lesson => mi.Lesson?.Title ?? "Lesson",
                ModuleItemType.Quiz => mi.Quiz?.Title ?? "Quiz",
                ModuleItemType.Assignment => mi.Assignment?.Title ?? "Assignment",
                ModuleItemType.Discussion => mi.Discussion?.Title ?? "Discussion",
                _ => "Unknown"
            };
        }

        public async Task<VideoLessonDto?> GetVideoLessonAsync(Guid itemId, Guid studentId)
        {
            var moduleItem = await _module.GetVideoLessonAsync(itemId);

            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Lesson.ContentType != LessonContentType.Video)
                throw new BusinessRuleException("Can not find lesson video");

            var isCompleted = await _progress.IsItemCompletedAsync(studentId, itemId);

            var questions = moduleItem.Lesson.LessonQuestions.Select(q => new LessonQuestionDto(
                q.Id,
                q.Content,
                q.LessonOptions.Select(opt => new LessonOptionDto(opt.Id, opt.Content, opt.IsCorrect)).ToList()
            )).ToList();
            return new VideoLessonDto(moduleItem.Id, moduleItem.Lesson.Title, moduleItem.Lesson.VideoUrl, isCompleted, questions);
        }

        public async Task SubmitLessonQuestionAsync(Guid studentId, SubmitLessonQuestionRequest request)
        {
            var moduleItem = await _module.GetVideoLessonAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Lesson == null)throw new BusinessRuleException("Can not find lesson video");

            var selectedOptionIds = request.Answers.Values.ToList();
            var selectedOptions = moduleItem.Lesson.LessonQuestions
                .SelectMany(q => q.LessonOptions)
                .Where(opt => selectedOptionIds.Contains(opt.Id))
                .ToList();

            if (selectedOptions.Count == moduleItem.Lesson.LessonQuestions.Count &&
                selectedOptions.All(opt => opt.IsCorrect))
            {
                var isUpdated = await _progress.UpdateProgressToCompletedAsync(studentId, request.ModuleItemId);
                if (!isUpdated) throw new BusinessRuleException("Cannot update progress");
                await _uow.SaveChangeAsync();
            }
            else
            {
                throw new BusinessRuleException("Your answers are incorrect. Please watch the video carefully and try again!");
            }
        }

        public async Task<(ModuleItemType ItemType, LessonContentType? ContentType)?> GetItemTypeInfoAsync(Guid itemId)
        {
            var item = await _module.GetItemTypeInfoAsync(itemId);
            if (item == null) throw new BusinessRuleException("Module items not found");
            return item;
        }
    }
}