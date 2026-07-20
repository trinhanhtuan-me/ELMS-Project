using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IQuizQuestionRepository
    {
        Task<List<QuizQuestion>> GetQuestionsByQuizIdAsync(Guid quizId);
        Task<QuizQuestion?> GetQuestionByIdAsync(Guid questionId);
        Task AddAsync(QuizQuestion question);
        void Delete(QuizQuestion question);
        Task ReplaceOptionsAsync(Guid questionId, List<QuizOption> newOptions);
    }
}
