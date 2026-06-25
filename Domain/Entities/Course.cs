using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Course : AuditableEntity<Guid>
{
    public Course() { Id = Guid.NewGuid(); }


    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Language { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string? Thumbnail { get; set; }

    public CourseStatus Status { get; set; }

    public DateTime? PublishAt { get; set; }

    public Guid CreatedBy { get; set; }

    public int CategoryId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<CourseManager> CourseManagers { get; set; } = new List<CourseManager>();

    public virtual CoursePrice? CoursePrice { get; set; }

    public virtual ICollection<CourseRequest> CourseRequests { get; set; } = new List<CourseRequest>();

    public virtual InstructorProfile CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}




