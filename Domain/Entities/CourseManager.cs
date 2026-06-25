using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourseManager
{
    public Guid CourseId { get; set; }

    public Guid UserId { get; set; }

    public string? RejectReason { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ManagerProfile User { get; set; } = null!;
}


