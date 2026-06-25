using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Progress
{
    public Guid StudentId { get; set; }

    public Guid ModuleItemId { get; set; }

    public ProgressStatus Status { get; set; }

    public decimal PercentDone { get; set; }

    public decimal? ScorePct { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ModuleItem ModuleItem { get; set; } = null!;

    public virtual StudentProfile Student { get; set; } = null!;
}



