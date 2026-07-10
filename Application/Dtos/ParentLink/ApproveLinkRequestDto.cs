using System;

namespace Application.Dtos.ParentLink;

public class ApproveLinkRequestDto
{
    public Guid RequestId { get; set; }
    public string? Note { get; set; }
}
