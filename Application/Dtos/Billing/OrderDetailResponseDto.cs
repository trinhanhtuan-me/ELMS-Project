using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Application.Dtos.Billing;

public class OrderDetailResponseDto
{
    public Guid OrderId { get; set; }
    public OrderStatus Status { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime? PaidAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalAmountVnd { get; set; }
    
    public List<OrderItemDetailDto> Items { get; set; } = new();
    
    // Payment details
    public string? TxnRef { get; set; }
    public DateTime? CapturedAt { get; set; }
}

public class OrderItemDetailDto
{
    public string CourseName { get; set; } = null!;
    public string StudentName { get; set; } = null!;
    public decimal PriceVnd { get; set; }
}
