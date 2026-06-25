using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class QuizAttempt : Entity<Guid>
{
    public QuizAttempt() { Id = Guid.NewGuid(); }

    public Guid QuizId { get; set; }

    public Guid StudentId { get; set; }

    public int AttemptNo { get; set; }

    public QuizAttemptStatus Status { get; set; }

    public decimal? ScorePct { get; set; }

    public bool IsPassed { get; set; }

    public DateTime StartedAt { get; set; }

    public DateTime? DeadlineAt { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public virtual ICollection<AttemptAnswer> AttemptAnswers { get; set; } = new List<AttemptAnswer>();

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual ICollection<QuizAttemptQuestion> QuizAttemptQuestions { get; set; } = new List<QuizAttemptQuestion>();

    public virtual StudentProfile Student { get; set; } = null!;
}




