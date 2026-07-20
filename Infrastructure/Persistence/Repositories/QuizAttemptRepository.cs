using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class QuizAttemptRepository(ElmsDbContext _context) : IQuizAttemptRepository
    {
        public async Task AddAttempt(QuizAttempt attempt)
        {
            await _context.QuizAttempts.AddAsync(attempt);
        }

        public async Task AddAttemptAnswers(IEnumerable<AttemptAnswer> answers)
        {
            await _context.AttemptAnswers.AddRangeAsync(answers);
        }

        public async Task AddAttemptQuestions(IEnumerable<QuizAttemptQuestion> questions)
        {
            await _context.QuizAttemptQuestions.AddRangeAsync(questions);
        }

        public async Task<int> CountAttemptsAsync(Guid studentId, Guid quizId)
        {
            return await _context.QuizAttempts
                .CountAsync(qa => qa.StudentId == studentId && qa.QuizId == quizId);
        }

        public async Task<QuizAttempt?> GetAttemptWithQuestionsAsync(Guid attemptId, Guid studentId)
        {
            return await _context.QuizAttempts
                .Include(qa => qa.QuizAttemptQuestions)
                    .ThenInclude(qaq => qaq.Question)
                        .ThenInclude(q => q.QuizOptions)
                .FirstOrDefaultAsync(qa => qa.Id == attemptId && qa.StudentId == studentId);
        }

        public async Task<decimal?> GetBestScoreAsync(Guid studentId, Guid quizId)
        {
            return await _context.QuizAttempts
                .Where(qa => qa.StudentId == studentId && qa.QuizId == quizId && qa.Status == QuizAttemptStatus.Submitted)
                .MaxAsync(qa => (decimal?)qa.ScorePct);
        }

        public async Task<QuizAttempt?> GetLastAttemptAsync(Guid studentId, Guid quizId)
        {
            return await _context.QuizAttempts
               .Where(qa => qa.StudentId == studentId && qa.QuizId == quizId)
               .OrderByDescending(qa => qa.StartedAt)
               .FirstOrDefaultAsync();
        }
    }
}
