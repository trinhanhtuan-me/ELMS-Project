using System;

namespace Application.Dtos.ParentProgress;

public class ChildModuleItemProgressDto
{
    public Guid ModuleItemId { get; set; }
    public string Title { get; set; } = null!;
    public string ItemType { get; set; } = null!;
    public string Status { get; set; } = null!;
    public decimal PercentDone { get; set; }
    public decimal? ScorePct { get; set; }
    public DateTime? CompletedAt { get; set; }
}
