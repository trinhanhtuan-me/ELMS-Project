using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Module : AuditableEntity<Guid>
{
    public Module() { Id = Guid.NewGuid(); }


    public Guid CourseId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int OrderIndex { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<ModuleItem> ModuleItems { get; set; } = new List<ModuleItem>();
}



