using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Flashcard : AuditableEntity<Guid>
{
    public Flashcard() { Id = Guid.NewGuid(); }


    public Guid SetId { get; set; }

    public string FrontText { get; set; } = null!;

    public string BackText { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public virtual FlashcardSet Set { get; set; } = null!;
}



