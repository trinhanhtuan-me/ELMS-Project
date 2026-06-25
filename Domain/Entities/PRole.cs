using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class PRole : Entity<int>
{

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public RoleStatus Status { get; set; } = RoleStatus.Active;

    public bool IsDeleted { get; set; }

    public virtual ICollection<PFunction> Functions { get; set; } = new List<PFunction>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}


