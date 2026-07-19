using System;

namespace Application.Dtos.ParentProgress;

public class ChildSummaryDto
{
    public Guid StudentId { get; set; }
    public string StudentName { get; set; } = null!;
    public string StudentEmail { get; set; } = null!;
    public int EnrolledCoursesCount { get; set; }
    public int CompletedCoursesCount { get; set; }
    public decimal AverageProgressPct { get; set; }
}
