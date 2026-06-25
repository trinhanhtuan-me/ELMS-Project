using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AttemptAnswer
{
    public Guid AttemptId { get; set; }

    public Guid ChosenOptionId { get; set; }

    public bool? IsCorrect { get; set; }

    public virtual QuizAttempt Attempt { get; set; } = null!;

    public virtual QuizOption ChosenOption { get; set; } = null!;
}


