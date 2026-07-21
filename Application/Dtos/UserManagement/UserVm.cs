using System;
using System.Collections.Generic;

namespace Application.Dtos.UserManagement
{
    public class UserVm
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<string> Roles { get; set; } = new();
    }
}
