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
    public class ManagerFlashcardRepository : IManagerFlashcardRepository
    {
        private readonly ElmsDbContext _context;

        public ManagerFlashcardRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FlashcardSet>> GetFlashcardSetsAsync(string keyword, string sortType)
        {
            // FlashcardSet -> Flashcards (đếm thẻ) -> Student -> User (lấy tên)
            var query = _context.FlashcardSets
                .Include(f => f.Flashcards)
                .Include(f => f.Student)
                    .ThenInclude(s => s.IdNavigation)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(f => f.Title.Contains(keyword) || (f.Description != null && f.Description.Contains(keyword)));
            }

            query = sortType switch
            {
                "oldest" => query.OrderBy(f => f.CreatedAt),
                "az" => query.OrderBy(f => f.Title),
                "za" => query.OrderByDescending(f => f.Title),
                _ => query.OrderByDescending(f => f.CreatedAt) 
            };

            return await query.ToListAsync();
        }

        public async Task<FlashcardSet?> GetFlashcardSetByIdAsync(Guid setId)
        {
            return await _context.FlashcardSets
                .Include(f => f.Student).ThenInclude(s => s.IdNavigation)
                .Include(f => f.Flashcards)
                .FirstOrDefaultAsync(f => f.Id == setId);
        }

        public async Task<IEnumerable<Flashcard>> GetFlashcardsBySetIdAsync(Guid setId)
        {
            return await _context.Flashcards.Where(f => f.SetId == setId).ToListAsync();
        }

        public async Task UpdateFlashcardSetAsync(FlashcardSet flashcardSet)
        {
            _context.FlashcardSets.Update(flashcardSet);
            await Task.CompletedTask;
        }
    }
}
