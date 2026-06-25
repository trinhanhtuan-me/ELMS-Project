using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Order : AuditableEntity<Guid>
{
    public Order() { Id = Guid.NewGuid(); }


    public Guid ParentId { get; set; }

    public OrderStatus Status { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public DateTime? PaidAt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ParentProfile Parent { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}




