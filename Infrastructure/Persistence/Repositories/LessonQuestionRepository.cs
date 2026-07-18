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
    public class LessonQuestionRepository : ILessonQuestionRepository
    {
        private readonly ElmsDbContext _context;

        public LessonQuestionRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<List<LessonQuestion>> GetQuestionsByLessonIdAsync(Guid lessonId)
        {
            return await _context.LessonQuestions
                .Include(q => q.LessonOptions)
                .Where(q => q.LessonId == lessonId)
                .ToListAsync();
        }

        public async Task<LessonQuestion?> GetByIdAsync(Guid id)
        {
            return await _context.LessonQuestions
                .Include(q => q.LessonOptions)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task AddAsync(LessonQuestion question)
        {
            await _context.LessonQuestions.AddAsync(question);
        }

        public Task UpdateAsync(LessonQuestion question)
        {
            _context.LessonQuestions.Update(question);
            return Task.CompletedTask;
        }

        public async Task ReplaceOptionsAsync(Guid questionId, List<LessonOption> newOptions)
        {
            var oldOptions = await _context.LessonOptions.Where(o => o.QuestionId == questionId).ToListAsync();
            _context.LessonOptions.RemoveRange(oldOptions);
            
            foreach(var opt in newOptions) {
                opt.QuestionId = questionId;
            }
            await _context.LessonOptions.AddRangeAsync(newOptions);
        }

        public void Delete(LessonQuestion question)
        {
            _context.LessonQuestions.Remove(question);
        }
    }
}
