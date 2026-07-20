using Application.Common.Interfaces;
using Application.Dtos.Lesson;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IQuizQuestionService
    {
        Task<List<QuizQuestionDto>> GetQuestionsByQuizIdAsync(Guid quizId, Guid userId);
        Task<bool> CreateQuestionAsync(QuizQuestionCreateRequest request, Guid userId);
        Task<bool> UpdateQuestionAsync(QuizQuestionUpdateRequest request, Guid userId);
        Task<bool> DeleteQuestionAsync(Guid questionId, Guid quizId, Guid userId);
        Task<QuizQuestionUpdateRequest?> GetQuestionForUpdateAsync(Guid questionId, Guid userId);
    }

    public class QuizQuestionService : IQuizQuestionService
    {
        private readonly IQuizQuestionRepository _quizQuestionRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly IModuleRepository _moduleRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _uow;

        public QuizQuestionService(
            IQuizQuestionRepository quizQuestionRepository,
            IModuleItemRepository moduleItemRepository,
            IModuleRepository moduleRepository,
            ICourseRepository courseRepository,
            IUnitOfWork uow)
        {
            _quizQuestionRepository = quizQuestionRepository;
            _moduleItemRepository = moduleItemRepository;
            _moduleRepository = moduleRepository;
            _courseRepository = courseRepository;
            _uow = uow;
        }

        private async Task<bool> CheckPermissionAsync(Guid quizId, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithQuizAsync(quizId);
            if (moduleItem == null || moduleItem.Quiz == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            return true;
        }

        public async Task<List<QuizQuestionDto>> GetQuestionsByQuizIdAsync(Guid quizId, Guid userId)
        {
            if (!await CheckPermissionAsync(quizId, userId)) return new List<QuizQuestionDto>();
            var questions = await _quizQuestionRepository.GetQuestionsByQuizIdAsync(quizId);
            return questions.Select(q => new QuizQuestionDto
            {
                Id = q.Id,
                QuizId = q.QuizId,
                Content = q.Content,
                Explanation = q.Explanation,
                Options = q.QuizOptions.Select(o => new QuizQuestionOptionDto
                {
                    Id = o.Id,
                    Content = o.Content,
                    IsCorrect = o.IsCorrect
                }).ToList()
            }).ToList();
        }

        public async Task<bool> CreateQuestionAsync(QuizQuestionCreateRequest request, Guid userId)
        {
            if (!await CheckPermissionAsync(request.QuizId, userId)) return false;

            var question = new QuizQuestion
            {
                QuizId = request.QuizId,
                Content = request.Content,
                Explanation = request.Explanation
            };

            foreach (var opt in request.Options)
            {
                question.QuizOptions.Add(new QuizOption
                {
                    Content = opt.Content,
                    IsCorrect = opt.IsCorrect
                });
            }

            await _quizQuestionRepository.AddAsync(question);
            await _uow.SaveChangeAsync();

            return true;
        }

        public async Task<bool> UpdateQuestionAsync(QuizQuestionUpdateRequest request, Guid userId)
        {
            if (!await CheckPermissionAsync(request.QuizId, userId)) return false;

            var question = await _quizQuestionRepository.GetQuestionByIdAsync(request.QuestionId);
            if (question == null) return false;

            question.Content = request.Content;
            question.Explanation = request.Explanation;

            // Prepare new options
            var newOptions = request.Options.Select(opt => new QuizOption
            {
                Content = opt.Content,
                IsCorrect = opt.IsCorrect
            }).ToList();

            await _quizQuestionRepository.ReplaceOptionsAsync(question.Id, newOptions);

            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> DeleteQuestionAsync(Guid questionId, Guid quizId, Guid userId)
        {
            if (!await CheckPermissionAsync(quizId, userId)) return false;

            var question = await _quizQuestionRepository.GetQuestionByIdAsync(questionId);
            if (question == null) return false;

            _quizQuestionRepository.Delete(question);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<QuizQuestionUpdateRequest?> GetQuestionForUpdateAsync(Guid questionId, Guid userId)
        {
            var question = await _quizQuestionRepository.GetQuestionByIdAsync(questionId);
            if (question == null) return null;

            if (!await CheckPermissionAsync(question.QuizId, userId)) return null;

            return new QuizQuestionUpdateRequest
            {
                QuestionId = question.Id,
                QuizId = question.QuizId,
                Content = question.Content,
                Explanation = question.Explanation,
                Options = question.QuizOptions.Select(o => new QuizQuestionOptionDto
                {
                    Id = o.Id,
                    Content = o.Content,
                    IsCorrect = o.IsCorrect
                }).ToList()
            };
        }
    }
}
