using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class PasswordResetToken : AuditableEntity<Guid>
{
    public PasswordResetToken() { Id = Guid.NewGuid(); }


    public Guid UserId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public DateTime? UsedAt { get; set; }

    public virtual User User { get; set; } = null!;
}



