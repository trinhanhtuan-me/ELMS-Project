using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class ParentLinkRequest : AuditableEntity<Guid>
{
    public ParentLinkRequest() { Id = Guid.NewGuid(); }


    public Guid StudentId { get; set; }

    public Guid ParentId { get; set; }

    public ParentLinkRequestStatus Status { get; set; }

    public string? Note { get; set; }

    public DateTime? DecidedAt { get; set; }

    public virtual ParentProfile Parent { get; set; } = null!;

    public virtual StudentProfile Student { get; set; } = null!;
}




