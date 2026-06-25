using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AssignmentWork
{
    public Guid AssignmentId { get; set; }

    public Guid StudentId { get; set; }

    public string? TextAnswer { get; set; }

    public string? FileUrl { get; set; }

    public AssignmentWorkStatus Status { get; set; }

    public decimal? Score { get; set; }

    public Guid? GraderId { get; set; }

    public string? FeedbackText { get; set; }

    public DateTime? DraftSavedAt { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public DateTime? GradedAt { get; set; }

    public virtual Assignment Assignment { get; set; } = null!;

    public virtual InstructorProfile? Grader { get; set; }

    public virtual StudentProfile Student { get; set; } = null!;
}



