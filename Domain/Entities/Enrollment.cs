using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Enrollment : Entity<Guid>
{
    public Enrollment() { Id = Guid.NewGuid(); }


    public Guid CourseId { get; set; }

    public Guid StudentId { get; set; }

    public EnrollmentStatus Status { get; set; }

    public DateTime EnrolledAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual StudentProfile Student { get; set; } = null!;
}




