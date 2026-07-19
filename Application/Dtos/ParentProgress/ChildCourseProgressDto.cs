using System;

namespace Application.Dtos.ParentProgress;

public class ChildCourseProgressDto
{
    public Guid CourseId { get; set; }
    public string CourseTitle { get; set; } = null!;
    public int TotalItems { get; set; }
    public int CompletedItems { get; set; }
    public decimal ProgressPct { get; set; }
    public decimal? AverageScorePct { get; set; }
}
