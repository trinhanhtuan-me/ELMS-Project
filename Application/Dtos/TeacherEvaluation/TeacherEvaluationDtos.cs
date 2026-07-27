using System;
using System.Collections.Generic;

namespace Application.Dtos.TeacherEvaluation
{
    public class TeacherOverviewDto
    {
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public string? Expertise { get; set; }
        public int TotalCourses { get; set; }
        public int TotalReviews { get; set; }
        public double AverageRating { get; set; }
        public int Star5Count { get; set; }
        public int Star4Count { get; set; }
        public int Star3Count { get; set; }
        public int Star2Count { get; set; }
        public int Star1Count { get; set; }
    }

    public class TeacherEvaluationFilterRequest
    {
        public string? SearchTerm { get; set; }
        public double? MinRating { get; set; }
        public string? SortBy { get; set; } = "rating_desc";
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class TeacherCourseSummaryDto
    {
        public Guid CourseId { get; set; }
        public string CourseTitle { get; set; } = null!;
        public string? Thumbnail { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int TotalReviews { get; set; }
        public double AverageRating { get; set; }
    }

    public class TeacherReviewDetailDto
    {
        public Guid ReviewId { get; set; }
        public Guid CourseId { get; set; }
        public string CourseTitle { get; set; } = null!;
        public Guid StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public string? StudentAvatar { get; set; }
        public byte Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class TeacherDetailEvaluationDto
    {
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public string? Expertise { get; set; }
        public int TotalCourses { get; set; }
        public int TotalReviews { get; set; }
        public double AverageRating { get; set; }
        public int Star5Count { get; set; }
        public int Star4Count { get; set; }
        public int Star3Count { get; set; }
        public int Star2Count { get; set; }
        public int Star1Count { get; set; }
        public List<TeacherCourseSummaryDto> Courses { get; set; } = new();
    }

    public class TeacherReviewFilterRequest
    {
        public Guid? CourseId { get; set; }
        public int? Rating { get; set; }
        public string? SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class TeacherEvaluationStatsDto
    {
        public int TotalTeachers { get; set; }
        public int TotalSystemReviews { get; set; }
        public double SystemAverageRating { get; set; }
        public string TopRatedTeacherName { get; set; } = "N/A";
        public double TopRatedTeacherRating { get; set; }
    }
}
