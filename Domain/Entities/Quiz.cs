using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Quiz : Entity<Guid>
{
    public Quiz() { Id = Guid.NewGuid(); }


    public string Title { get; set; } = null!;

    public decimal PassingScorePct { get; set; }

    public int? PickCount { get; set; }

    public int? TimeLimitMin { get; set; }

    public int MaxAttempts { get; set; }

    public virtual ModuleItem IdNavigation { get; set; } = null!;

    public virtual ICollection<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();

    public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new List<QuizQuestion>();
}



