using System;

namespace Application.Dtos.Billing;

public class ApproveCourseRequestDto
{
    public Guid RequestId { get; set; }
    public string? Note { get; set; }
}
