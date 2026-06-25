using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class PFunction : Entity<int>
{

    public int CategoryId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public virtual PCategory Category { get; set; } = null!;

    public virtual ICollection<PRole> Roles { get; set; } = new List<PRole>();
}


