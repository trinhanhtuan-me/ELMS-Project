using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class User : AuditableEntity<Guid>
{
    public User() { Id = Guid.NewGuid(); }


    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string? Avatar { get; set; }

    public string? FullName { get; set; }

    public string? Password { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Phone { get; set; }

    public Gender? Gender { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<DiscussionReply> DiscussionReplies { get; set; } = new List<DiscussionReply>();

    public virtual InstructorProfile? InstructorProfile { get; set; }

    public virtual ManagerProfile? ManagerProfile { get; set; }

    public virtual ICollection<OauthAccount> OauthAccounts { get; set; } = new List<OauthAccount>();

    public virtual ParentProfile? ParentProfile { get; set; }

    public virtual ICollection<PasswordResetToken> PasswordResetTokens { get; set; } = new List<PasswordResetToken>();

    public virtual StudentProfile? StudentProfile { get; set; }

    public virtual ICollection<PRole> Roles { get; set; } = new List<PRole>();
}




