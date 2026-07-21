using Domain.Enums;
using System;

namespace Application.Dtos.InstructorProfile
{
    public class InstructorProfileVm
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? FullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public Gender? Gender { get; set; }
    }
}
