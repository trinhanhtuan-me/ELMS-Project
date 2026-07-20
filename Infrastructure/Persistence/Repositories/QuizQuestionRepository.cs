using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class QuizQuestionRepository : IQuizQuestionRepository
    {
        private readonly ElmsDbContext _context;

        public QuizQuestionRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(QuizQuestion question)
        {
            await _context.QuizQuestions.AddAsync(question);
        }

        public void Delete(QuizQuestion question)
        {
            question.IsDeleted = true;
            _context.QuizQuestions.Update(question);
        }

        public async Task ReplaceOptionsAsync(Guid questionId, List<QuizOption> newOptions)
        {
            var oldOptions = await _context.QuizOptions.Where(o => o.QuestionId == questionId).ToListAsync();
            _context.QuizOptions.RemoveRange(oldOptions);
            
            foreach (var opt in newOptions)
            {
                opt.QuestionId = questionId;
            }
            await _context.QuizOptions.AddRangeAsync(newOptions);
        }

        public async Task<QuizQuestion?> GetQuestionByIdAsync(Guid questionId)
        {
            return await _context.QuizQuestions
                .Include(q => q.QuizOptions)
                .FirstOrDefaultAsync(q => q.Id == questionId && !q.IsDeleted);
        }

        public async Task<List<QuizQuestion>> GetQuestionsByQuizIdAsync(Guid quizId)
        {
            return await _context.QuizQuestions
                .Include(q => q.QuizOptions)
                .Where(q => q.QuizId == quizId && !q.IsDeleted)
                .ToListAsync();
        }
    }
}
