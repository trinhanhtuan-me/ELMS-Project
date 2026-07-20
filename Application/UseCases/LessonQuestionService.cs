using Application.Dtos.Lesson;
using Application.Interfaces;
using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ILessonQuestionService
    {
        Task<List<LessonQuestionDto>> GetQuestionsByLessonIdAsync(Guid lessonId);
        Task<LessonQuestionDto?> GetQuestionByIdAsync(Guid questionId);
        Task<bool> CreateQuestionAsync(LessonQuestionCreateRequest request);
        Task<bool> UpdateQuestionAsync(LessonQuestionUpdateRequest request);
        Task<bool> DeleteQuestionAsync(Guid questionId);
    }
    public class LessonQuestionService : ILessonQuestionService
    {
        private readonly ILessonQuestionRepository _repository;
        private readonly IUnitOfWork _uow;

        public LessonQuestionService(ILessonQuestionRepository repository, IUnitOfWork uow)
        {
            _repository = repository;
            _uow = uow;
        }

        public async Task<List<LessonQuestionDto>> GetQuestionsByLessonIdAsync(Guid lessonId)
        {
            var questions = await _repository.GetQuestionsByLessonIdAsync(lessonId);
            return questions.Select(MapToDto).ToList();
        }

        public async Task<LessonQuestionDto?> GetQuestionByIdAsync(Guid questionId)
        {
            var question = await _repository.GetByIdAsync(questionId);
            if (question == null) return null;
            return MapToDto(question);
        }

        public async Task<bool> CreateQuestionAsync(LessonQuestionCreateRequest request)
        {
            if (request.Options == null || request.Options.Count < 2) return false;
            if (!request.Options.Any(o => o.IsCorrect)) return false;

            var question = new LessonQuestion
            {
                LessonId = request.LessonId,
                Content = request.Content,
                Explanation = request.Explanation,
                LessonOptions = request.Options.Select(o => new LessonOption
                {
                    Content = o.Content,
                    IsCorrect = o.IsCorrect
                }).ToList()
            };

            await _repository.AddAsync(question);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> UpdateQuestionAsync(LessonQuestionUpdateRequest request)
        {
            var question = await _repository.GetByIdAsync(request.Id);
            if (question == null) return false;

            if (request.Options == null || request.Options.Count < 2) return false;
            if (!request.Options.Any(o => o.IsCorrect)) return false;

            question.Content = request.Content;
            question.Explanation = request.Explanation;

            await _repository.UpdateAsync(question);

            var newOptions = request.Options.Select(opt => new LessonOption
            {
                Content = opt.Content,
                IsCorrect = opt.IsCorrect
            }).ToList();

            await _repository.ReplaceOptionsAsync(question.Id, newOptions);

            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> DeleteQuestionAsync(Guid questionId)
        {
            var question = await _repository.GetByIdAsync(questionId);
            if (question == null) return false;

            _repository.Delete(question);
            await _uow.SaveChangeAsync();
            return true;
        }

        private LessonQuestionDto MapToDto(LessonQuestion entity)
        {
            return new LessonQuestionDto
            {
                Id = entity.Id,
                LessonId = entity.LessonId,
                Content = entity.Content,
                Explanation = entity.Explanation,
                Options = entity.LessonOptions.Select(o => new LessonOptionDto
                {
                    Id = o.Id,
                    Content = o.Content,
                    IsCorrect = o.IsCorrect
                }).ToList()
            };
        }
    }
}
