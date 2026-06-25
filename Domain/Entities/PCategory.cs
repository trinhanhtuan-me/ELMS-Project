using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class PCategory : Entity<int>
{

    public string? Identity { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<PFunction> PFunctions { get; set; } = new List<PFunction>();
}


