using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class StudentVocabulary : AuditableEntity<Guid>
{
    public StudentVocabulary() { Id = Guid.NewGuid(); }


    public Guid UserId { get; set; }

    public string Word { get; set; } = null!;

    public string? Phonetic { get; set; }

    public string? AudioUrl { get; set; }

    public string? PartOfSpeech { get; set; }

    public string? Definition { get; set; }

    public string? Example { get; set; }

    public string? Synonyms { get; set; }

    public string? Antonyms { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual StudentProfile User { get; set; } = null!;
}



