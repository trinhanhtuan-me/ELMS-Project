using Domain.Enums;
using System;

namespace Application.Dtos.Billing;

public class OrderResponseDto
{
    public Guid OrderId { get; set; }
    public OrderStatus Status { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime? PaidAt { get; set; }
    public decimal TotalAmountVnd { get; set; }
    public int CourseCount { get; set; }
    public DateTime CreatedAt { get; set; }
}
