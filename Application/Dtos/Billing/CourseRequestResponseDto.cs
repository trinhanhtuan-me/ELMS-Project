using Domain.Enums;
using System;

namespace Application.Dtos.Billing;

public class CourseRequestResponseDto
{
    public Guid RequestId { get; set; }
    public Guid StudentId { get; set; }
    public string StudentName { get; set; } = null!;
    public string StudentEmail { get; set; } = null!;
    public Guid CourseId { get; set; }
    public string CourseName { get; set; } = null!;
    public decimal PriceVnd { get; set; }
    public CourseRequestStatus Status { get; set; }
    public string? Note { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DecidedAt { get; set; }
}
