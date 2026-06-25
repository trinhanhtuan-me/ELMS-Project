using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Assignment : Entity<Guid>
{
    public Assignment() { Id = Guid.NewGuid(); }


    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Instructions { get; set; } = null!;

    public AssignmentSubmissionType SubmissionType { get; set; }

    public string? AttachmentUrl { get; set; }

    public decimal MaxScore { get; set; }

    public decimal PassingScorePct { get; set; }

    public virtual ICollection<AssignmentWork> AssignmentWorks { get; set; } = new List<AssignmentWork>();

    public virtual ModuleItem IdNavigation { get; set; } = null!;
}




