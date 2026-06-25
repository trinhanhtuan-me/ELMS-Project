using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class ParentProfile : AuditableEntity<Guid>
{
    public ParentProfile() { Id = Guid.NewGuid(); }


    public string? Address { get; set; }

    public string? Occupation { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CourseRequest> CourseRequests { get; set; } = new List<CourseRequest>();

    public virtual User IdNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ParentLinkRequest> ParentLinkRequests { get; set; } = new List<ParentLinkRequest>();

    public virtual ICollection<StudentProfile> StudentProfiles { get; set; } = new List<StudentProfile>();
}



