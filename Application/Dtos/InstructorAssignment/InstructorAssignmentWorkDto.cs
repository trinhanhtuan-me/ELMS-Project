using Domain.Enums;
using System;

namespace Application.Dtos.InstructorAssignment
{
    public class InstructorAssignmentWorkDto
    {
        public Guid AssignmentId { get; set; }
        public Guid StudentId { get; set; }
        
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        
        public string CourseTitle { get; set; } = string.Empty;
        public string ModuleTitle { get; set; } = string.Empty;
        public string AssignmentTitle { get; set; } = string.Empty;
        
        public string? TextAnswer { get; set; }
        public string? FileUrl { get; set; }
        public AssignmentWorkStatus Status { get; set; }
        public decimal? Score { get; set; }
        public decimal MaxScore { get; set; }
        public decimal PassingScorePct { get; set; }
        
        public DateTime? SubmittedAt { get; set; }
        public DateTime? GradedAt { get; set; }
    }
}
