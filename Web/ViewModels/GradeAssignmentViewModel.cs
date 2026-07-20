using System;
using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class GradeAssignmentViewModel
    {
        [Required]
        public Guid AssignmentId { get; set; }
        
        [Required]
        public Guid StudentId { get; set; }
        
        [Required(ErrorMessage = "Please enter a score.")]
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100.")]
        public decimal Score { get; set; }
        
        public string? Feedback { get; set; }

        // Read-only info for displaying in the Grade page
        public string? StudentName { get; set; }
        public string? CourseTitle { get; set; }
        public string? AssignmentTitle { get; set; }
        public string? TextAnswer { get; set; }
        public string? FileUrl { get; set; }
        public decimal MaxScore { get; set; }
        public DateTime? SubmittedAt { get; set; }
    }
}
