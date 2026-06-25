using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class SystemKey : Entity<int>
{

    public int? ParentId { get; set; }

    public string CodeKey { get; set; } = null!;

    public int CodeValue { get; set; }

    public string Description { get; set; } = null!;

    public int? SortOrder { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<SystemKey> InverseParent { get; set; } = new List<SystemKey>();

    public virtual SystemKey? Parent { get; set; }
}


