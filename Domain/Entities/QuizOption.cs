using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class QuizOption : Entity<Guid>
{
    public QuizOption() { Id = Guid.NewGuid(); }


    public Guid QuestionId { get; set; }

    public string Content { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public virtual ICollection<AttemptAnswer> AttemptAnswers { get; set; } = new List<AttemptAnswer>();

    public virtual QuizQuestion Question { get; set; } = null!;
}



