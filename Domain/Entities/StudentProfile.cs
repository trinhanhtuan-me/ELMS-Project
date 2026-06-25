using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class StudentProfile : AuditableEntity<Guid>
{
    public StudentProfile() { Id = Guid.NewGuid(); }


    public string? GradeLevel { get; set; }

    public string? Institution { get; set; }

    public Guid? ParentId { get; set; }

    public string? Address { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<AssignmentWork> AssignmentWorks { get; set; } = new List<AssignmentWork>();

    public virtual ICollection<CourseRequest> CourseRequests { get; set; } = new List<CourseRequest>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<FlashcardSet> FlashcardSets { get; set; } = new List<FlashcardSet>();

    public virtual User IdNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ParentProfile? Parent { get; set; }

    public virtual ICollection<ParentLinkRequest> ParentLinkRequests { get; set; } = new List<ParentLinkRequest>();

    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();

    public virtual ICollection<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<StudentVocabulary> StudentVocabularies { get; set; } = new List<StudentVocabulary>();
}



