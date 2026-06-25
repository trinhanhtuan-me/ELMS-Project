using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class CoursePrice : AuditableEntity<Guid>
{
    public CoursePrice() { Id = Guid.NewGuid(); }


    public Guid CourseId { get; set; }

    public decimal PriceAmount { get; set; }

    public DateTime EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual Course Course { get; set; } = null!;
}



