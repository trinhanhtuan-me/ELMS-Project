using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Application.Dtos.UserManagement
{
    public class UpdateUserRequest
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;

        public string? FullName { get; set; }

        public string? Phone { get; set; }

        public Gender? Gender { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public bool IsActive { get; set; }

        public List<int> RoleIds { get; set; } = new();
    }
}
