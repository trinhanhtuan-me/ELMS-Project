using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILessonQuestionRepository
    {
        Task<List<LessonQuestion>> GetQuestionsByLessonIdAsync(Guid lessonId);
        Task<LessonQuestion?> GetByIdAsync(Guid id);
        Task AddAsync(LessonQuestion question);
        Task UpdateAsync(LessonQuestion question);
        Task ReplaceOptionsAsync(Guid questionId, List<LessonOption> newOptions);
        void Delete(LessonQuestion question);
    }
}
