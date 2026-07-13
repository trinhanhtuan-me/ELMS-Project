using System;

namespace Application.Dtos.Manager;

public class CourseListVm
{
    public Guid CourseId { get; set; }
    public string Title { get; set; } = null!;
    public string? Thumbnail { get; set; }
    public string CategoryName { get; set; } = null!;

    public string TeacherName { get; set; } = null!;
    public string? TeacherAvatar { get; set; }
    public string TeacherEmail { get; set; } = null!;

    public string CreatedDate { get; set; } = null!;
    public string CreatedTime { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public string? PublishDate { get; set; }
    public string? PublishTime { get; set; }

    public string Status { get; set; } = null!;
    public decimal Price { get; set; }
}
