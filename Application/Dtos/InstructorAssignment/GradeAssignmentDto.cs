using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.InstructorAssignment
{
    public class GradeAssignmentDto
    {
        [Required]
        public Guid AssignmentId { get; set; }
        
        [Required]
        public Guid StudentId { get; set; }
        
        [Required(ErrorMessage = "Score is required.")]
        [Range(0, 100, ErrorMessage = "Score must be between 0 and 100.")]
        public decimal Score { get; set; }
        
        public string? Feedback { get; set; }
    }
}
