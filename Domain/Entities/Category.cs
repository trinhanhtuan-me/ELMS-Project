using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Category : Entity<int>
{

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}


