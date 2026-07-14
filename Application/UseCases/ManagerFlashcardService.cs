using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerFlashcardService
    {
        Task<IEnumerable<FlashcardSetVm>> GetFlashcardSetsAsync(string keyword, string sortType);
        Task<FlashcardSetVm?> GetFlashcardSetDetailAsync(Guid setId);
        Task<IEnumerable<FlashcardVm>> GetFlashcardsBySetIdAsync(Guid setId);
        Task<bool> ToggleSetStatusAsync(Guid setId, string action);
    }

    public class ManagerFlashcardService : IManagerFlashcardService
    {
        private readonly IManagerFlashcardRepository _flashcardRepo;
        private readonly IUnitOfWork _uow;

        public ManagerFlashcardService(IManagerFlashcardRepository flashcardRepo, IUnitOfWork uow)
        {
            _flashcardRepo = flashcardRepo;
            _uow = uow;
        }

        public async Task<IEnumerable<FlashcardSetVm>> GetFlashcardSetsAsync(string keyword, string sortType)
        {
            var sets = await _flashcardRepo.GetFlashcardSetsAsync(keyword, sortType);

            return sets.Select(s => new FlashcardSetVm
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                TermCount = s.Flashcards.Count, 
                AuthorUsername = s.Student.IdNavigation.Username, 
                Status = s.Status.ToString().ToLower()
            });
        }

        public async Task<FlashcardSetVm> GetFlashcardSetDetailAsync(Guid setId)
        {
            var s = await _flashcardRepo.GetFlashcardSetByIdAsync(setId);

            if (s == null)
                throw new BusinessRuleException("Flashcard set not existed or was deleted in system!");
            return new FlashcardSetVm
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                TermCount = s.Flashcards.Count,
                AuthorUsername = s.Student.IdNavigation.Username,
                Status = s.Status.ToString().ToLower()
            };
        }

        public async Task<IEnumerable<FlashcardVm>> GetFlashcardsBySetIdAsync(Guid setId)
        {
            var cards = await _flashcardRepo.GetFlashcardsBySetIdAsync(setId);
            return cards.Select(c => new FlashcardVm
            {
                Id = c.Id,
                FrontText = c.FrontText,
                BackText = c.BackText
            });
        }

        public async Task<bool> ToggleSetStatusAsync(Guid setId, string action)
        {
            var set = await _flashcardRepo.GetFlashcardSetByIdAsync(setId);
            if (set == null) throw new BusinessRuleException("Flashcard set not found!");

            if (action == "hideSet")
            {
                set.Status = FlashcardSetStatus.Inactive;
            }
            else if (action == "activateSet")
            {
                set.Status = FlashcardSetStatus.Public;
            }

            await _flashcardRepo.UpdateFlashcardSetAsync(set);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}
