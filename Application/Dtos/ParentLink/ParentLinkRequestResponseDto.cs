using Domain.Enums;
using System;

namespace Application.Dtos.ParentLink;

public class ParentLinkRequestResponseDto
{
    public Guid RequestId { get; set; }
    public Guid StudentId { get; set; }
    public string StudentName { get; set; } = null!;
    public string StudentEmail { get; set; } = null!;
    public ParentLinkRequestStatus Status { get; set; }
    public string? Note { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DecidedAt { get; set; }
}
