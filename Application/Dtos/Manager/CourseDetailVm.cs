using System;
using System.Collections.Generic;

namespace Application.Dtos.Manager
{
    // Bao bọc toàn bộ dữ liệu của trang Detail
    public class CourseDetailVm
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Status { get; set; } = string.Empty; 
        public decimal? Price { get; set; }

        public CourseStatsVm Stats { get; set; } = new();
        public InstructorDetailVm Instructor { get; set; } = new();
        public List<ModuleDetailVm> Modules { get; set; } = new();
    }

    // Phần thống kê tổng số bài
    public class CourseStatsVm
    {
        public int ModuleCount { get; set; }
        public int LessonCount { get; set; }
        public int QuizCount { get; set; }
        public int AssignmentCount { get; set; }
        public int DiscussionCount { get; set; }
    }

    // Thông tin Giảng viên phụ trách
    public class InstructorDetailVm
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Expertise { get; set; }
        public string? Bio { get; set; }
    }

    // Dữ liệu của một Chương học (Module)
    public class ModuleDetailVm
    {
        public Guid ModuleId { get; set; }
        public int OrderIndex { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<ModuleItemDetailVm> Items { get; set; } = new();
    }

    // Dữ liệu tổng hợp cho một Bài học / Quiz / Bài tập / Thảo luận
    public class ModuleItemDetailVm
    {
        public Guid ItemId { get; set; }
        public Guid ModuleId { get; set; }
        public string ItemType { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        // Lesson 
        public string? ContentType { get; set; }
        public string? VideoUrl { get; set; }
        public int? DurationSec { get; set; }
        public string? TextContent { get; set; }
        public List<QuestionDetailVm> Questions { get; set; } = new();

        // Quiz 
        public int? TimeLimitMin { get; set; }
        public decimal? QuizPassingPct { get; set; }
        public int? PickCount { get; set; }

        // Assignment
        public string? SubmissionType { get; set; }
        public decimal? AssignmentPassingPct { get; set; }
        public string? AssignmentInstructions { get; set; }
        public string? AttachmentUrl { get; set; }
        public string? AssignmentContent { get; set; }

        // Discussion ---
        public string? DiscussionDescription { get; set; }
    }

    // Câu hỏi (dành cho Lesson hoặc Quiz)
    public class QuestionDetailVm
    {
        public Guid QuestionId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? MediaUrl { get; set; }
        public string? Explanation { get; set; }

        public List<QuestionOptionVm> Options { get; set; } = new();
    }

    // Các đáp án trắc nghiệm 
    public class QuestionOptionVm
    {
        public string Content { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }
    }
}
