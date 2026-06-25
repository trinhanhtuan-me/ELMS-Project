using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Payment : AuditableEntity<Guid>
{
    public Payment() { Id = Guid.NewGuid(); }


    public Guid OrderId { get; set; }

    public decimal AmountVnd { get; set; }

    public PaymentMethod PaymentMethod { get; set; }

    public PaymentStatus Status { get; set; }

    public string TxnRef { get; set; } = null!;

    public DateTime? CapturedAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}




