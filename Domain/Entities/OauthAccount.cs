using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class OauthAccount : Entity<Guid>
{
    public OauthAccount() { Id = Guid.NewGuid(); }


    public Guid UserId { get; set; }

    public string Provider { get; set; } = null!;

    public string ProviderUserId { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}



