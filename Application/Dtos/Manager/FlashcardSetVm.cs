using System;

namespace Application.Dtos.Manager
{
    public class FlashcardSetVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public int TermCount { get; set; } 
        public string AuthorUsername { get; set; } = null!; 

        public string Status { get; set; } = null!; // "Public", "Private", "Inactive"
    }
    public class FlashcardVm
    {
        public Guid Id { get; set; }
        public string FrontText { get; set; } = null!;
        public string BackText { get; set; } = null!;
    }
}
