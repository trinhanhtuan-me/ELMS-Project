using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IManagerFlashcardRepository
    {
        Task<IEnumerable<FlashcardSet>> GetFlashcardSetsAsync(string keyword, string sortType);
        Task<FlashcardSet?> GetFlashcardSetByIdAsync(Guid setId);
        Task<IEnumerable<Flashcard>> GetFlashcardsBySetIdAsync(Guid setId);
        Task UpdateFlashcardSetAsync(FlashcardSet flashcardSet);
    }
}
