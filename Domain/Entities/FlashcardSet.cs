using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class FlashcardSet : AuditableEntity<Guid>
{
    public FlashcardSet() { Id = Guid.NewGuid(); }


    public Guid StudentId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public FlashcardSetStatus Status { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Flashcard> Flashcards { get; set; } = new List<Flashcard>();

    public virtual StudentProfile Student { get; set; } = null!;
}




