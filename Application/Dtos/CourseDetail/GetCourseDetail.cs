using Application.Dtos.CourseReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseDetail
{
    public class PublicCourseDetailVm
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Thumbnail { get; set; }
        public string InstructorName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public double AverageRating { get; set; }
        public int TotalReviews { get; set; }
        public int TotalStudents { get; set; }
        // Trạng thái hiển thị nút bấm: "Enrolled", "Requested", hoặc "None"
        public string ButtonState { get; set; } = "None";
        public List<PublicModuleVm> Modules { get; set; } = new List<PublicModuleVm>();
        public List<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();
    }
    public class PublicModuleVm
    {
        public Guid ModuleId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int VideoCount { get; set; }
        public int ReadingCount { get; set; }
        public int AssignmentCount { get; set; }
        public int QuizCount { get; set; }
        public int DiscussionCount { get; set; }
        public List<PublicModuleItemVm> Items { get; set; } = new List<PublicModuleItemVm>();
    }
    public class PublicModuleItemVm
    {
        public string Title { get; set; } = string.Empty;
        public string ItemType { get; set; } = string.Empty; // "Video", "Reading", "Assignment", "Quiz", "Discussion"
    }
}
