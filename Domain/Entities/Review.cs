using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Review : AuditableEntity<Guid>
{
    public Review() { Id = Guid.NewGuid(); }


    public Guid CourseId { get; set; }

    public Guid StudentId { get; set; }

    public byte Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual StudentProfile Student { get; set; } = null!;
}



