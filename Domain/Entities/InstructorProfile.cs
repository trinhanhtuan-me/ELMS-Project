using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class InstructorProfile : AuditableEntity<Guid>
{
    public InstructorProfile() { Id = Guid.NewGuid(); }


    public string? Bio { get; set; }

    public string? Expertise { get; set; }

    public string? Qualifications { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<AssignmentWork> AssignmentWorks { get; set; } = new List<AssignmentWork>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual User IdNavigation { get; set; } = null!;
}



