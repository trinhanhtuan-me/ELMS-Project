using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class CourseRequest : AuditableEntity<Guid>
{
    public CourseRequest() { Id = Guid.NewGuid(); }


    public Guid StudentId { get; set; }

    public Guid CourseId { get; set; }

    public Guid ParentId { get; set; }

    public CourseRequestStatus Status { get; set; }

    public string? Note { get; set; }

    public DateTime? DecidedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ParentProfile Parent { get; set; } = null!;

    public virtual StudentProfile Student { get; set; } = null!;
}




