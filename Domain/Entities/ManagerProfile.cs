using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class ManagerProfile : AuditableEntity<Guid>
{
    public ManagerProfile() { Id = Guid.NewGuid(); }


    public string? Position { get; set; }

    public string? Specialization { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CourseManager> CourseManagers { get; set; } = new List<CourseManager>();

    public virtual User IdNavigation { get; set; } = null!;
}



