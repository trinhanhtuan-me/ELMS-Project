using Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;

namespace Application.Dtos.ParentProfile
{
    public class ParentProfileVm
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? FullName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public Gender? Gender { get; set; }
        public string? Address { get; set; }
        public string? Occupation { get; set; }
        public string? AvatarUrl { get; set; }
        public IFormFile? AvatarFile { get; set; }
    }
}
