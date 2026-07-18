using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IQuizAttemptRepository
    {
        Task<QuizAttempt?> GetLastAttemptAsync(Guid studentId, Guid quizId);
        Task<int> CountAttemptsAsync(Guid studentId, Guid quizId);
        Task<decimal?> GetBestScoreAsync(Guid studentId, Guid quizId);
        Task<QuizAttempt?> GetAttemptWithQuestionsAsync(Guid attemptId, Guid studentId);
        Task AddAttempt(QuizAttempt attempt);
        Task AddAttemptQuestions(IEnumerable<QuizAttemptQuestion> questions);
        Task AddAttemptAnswers(IEnumerable<AttemptAnswer> answers);
    }
}
