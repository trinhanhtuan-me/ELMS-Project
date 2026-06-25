using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class QuizAttemptQuestion : Entity<Guid>
{
    public QuizAttemptQuestion() { Id = Guid.NewGuid(); }


    public Guid AttemptId { get; set; }

    public Guid QuestionId { get; set; }

    public byte DisplayOrder { get; set; }

    public virtual QuizAttempt Attempt { get; set; } = null!;

    public virtual QuizQuestion Question { get; set; } = null!;
}



