using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class QuizQuestion : Entity<Guid>
{
    public QuizQuestion() { Id = Guid.NewGuid(); }


    public Guid QuizId { get; set; }

    public string Content { get; set; } = null!;

    public string? MediaUrl { get; set; }

    public string? Explanation { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual ICollection<QuizAttemptQuestion> QuizAttemptQuestions { get; set; } = new List<QuizAttemptQuestion>();

    public virtual ICollection<QuizOption> QuizOptions { get; set; } = new List<QuizOption>();
}



