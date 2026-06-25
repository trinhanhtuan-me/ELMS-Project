using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class OrderItem : Entity<Guid>
{
    public OrderItem() { Id = Guid.NewGuid(); }


    public Guid OrderId { get; set; }

    public Guid? RequestId { get; set; }

    public Guid CourseId { get; set; }

    public Guid StudentId { get; set; }

    public decimal PriceVnd { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual CourseRequest? Request { get; set; }

    public virtual StudentProfile Student { get; set; } = null!;
}



