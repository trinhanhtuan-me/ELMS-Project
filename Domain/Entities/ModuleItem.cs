using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class ModuleItem : AuditableEntity<Guid>
{
    public ModuleItem() { Id = Guid.NewGuid(); }


    public Guid ModuleId { get; set; }

    public ModuleItemType ItemType { get; set; }

    public int OrderIndex { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual Assignment? Assignment { get; set; }

    public virtual Discussion? Discussion { get; set; }

    public virtual Lesson? Lesson { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual ICollection<Progress> Progresses { get; set; } = new List<Progress>();

    public virtual Quiz? Quiz { get; set; }
}




