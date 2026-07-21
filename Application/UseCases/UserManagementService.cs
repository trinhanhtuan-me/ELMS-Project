using Application.Common;
using Application.Common.Interfaces;
using Application.Dtos.UserManagement;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IUserManagementService
    {
        Task<PaginatedList<UserVm>> GetList(GetListUserRequest request);
        Task<UpdateUserRequest> GetUserForEdit(Guid userId);
        Task Update(UpdateUserRequest request, Guid currentUserId);
        Task Create(CreateUserRequest request, Guid currentUserId);
    }

    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserManagementService(IUserRepository userRepository, IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<PaginatedList<UserVm>> GetList(GetListUserRequest request)
        {
            var pageNumber = request.PageNumber <= 0 ? 1 : request.PageNumber;
            var pageSize = request.PageSize <= 0 ? 10 : request.PageSize;
            if (pageSize > 100) pageSize = 100;

            var users = await _userRepository.GetListUsersAsync(request.SearchTerm, request.RoleId, request.IsActive, pageNumber, pageSize);
            var count = await _userRepository.CountAsync(request.SearchTerm, request.RoleId, request.IsActive);

            var data = users.Select(u => new UserVm
            {
                Id = u.Id,
                Username = u.Username,
                Email = u.Email,
                FullName = u.FullName,
                Phone = u.Phone,
                IsActive = u.IsActive,
                IsDeleted = u.IsDeleted,
                Roles = u.Roles.Select(r => r.Name).ToList()
            }).ToList();

            return new PaginatedList<UserVm>(count, data);
        }

        public async Task<UpdateUserRequest> GetUserForEdit(Guid userId)
        {
            var user = await _userRepository.FindUserWithRolesByIdAsync(userId);
            if (user == null) throw new BusinessRuleException("User not found.");

            return new UpdateUserRequest
            {
                UserId = user.Id,
                Email = user.Email,
                Username = user.Username,
                FullName = user.FullName,
                Phone = user.Phone,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                IsActive = user.IsActive,
                RoleIds = user.Roles.Select(r => r.Id).ToList()
            };
        }

        public async Task Update(UpdateUserRequest request, Guid currentUserId)
        {
            var user = await _userRepository.FindUserWithRolesByIdAsync(request.UserId);
            if (user == null) throw new BusinessRuleException("User not found.");

            // 1. Validate email and username uniqueness
            var existingUser = await _userRepository.FindUserByEmailOrUsernameAsync(request.Username, request.Email);
            if (existingUser != null && existingUser.Id != request.UserId)
            {
                throw new BusinessRuleException("Username or Email already exists.");
            }

            // 2. Perform Role checks
            bool currentlyIsAdmin = user.Roles.Any(r => r.Id == 1);
            bool requestHasAdmin = request.RoleIds.Contains(1);

            // A. If the user was an Admin, they MUST remain an Admin.
            if (currentlyIsAdmin && !requestHasAdmin)
            {
                throw new BusinessRuleException("Cannot remove the Admin role from an Administrator.");
            }

            // B. If the user was NOT an Admin, they CANNOT be assigned the Admin role.
            if (!currentlyIsAdmin && requestHasAdmin)
            {
                throw new BusinessRuleException("Cannot grant the Admin role to a user.");
            }

            // 3. Update fields
            user.Email = request.Email;
            user.Username = request.Username;
            user.FullName = request.FullName;
            user.Phone = request.Phone;
            user.Gender = request.Gender;
            user.DateOfBirth = request.DateOfBirth;
            user.IsActive = request.IsActive;
            user.UpdatedAt = DateTime.UtcNow;
            user.UpdatedBy = currentUserId;

            // 4. Update roles (preserving Admin role correctly based on the constraints checked above)
            // Fetch the valid roles to assign
            user.Roles.Clear();
            foreach (var rId in request.RoleIds)
            {
                var role = await _roleRepository.FindRoleById(rId);
                if (role != null)
                {
                    user.Roles.Add(role);
                }
            }

            // 5. Ensure profile records exist for assigned roles
            foreach (var role in user.Roles)
            {
                if (role.Name.Equals("Student", StringComparison.OrdinalIgnoreCase) && user.StudentProfile == null)
                {
                    user.StudentProfile = new StudentProfile { Id = user.Id };
                }
                else if (role.Name.Equals("Parent", StringComparison.OrdinalIgnoreCase) && user.ParentProfile == null)
                {
                    user.ParentProfile = new ParentProfile { Id = user.Id };
                }
                else if ((role.Name.Equals("Teacher", StringComparison.OrdinalIgnoreCase) || role.Name.Equals("Instructor", StringComparison.OrdinalIgnoreCase)) && user.InstructorProfile == null)
                {
                    user.InstructorProfile = new InstructorProfile { Id = user.Id };
                }
                else if (role.Name.Equals("Manager", StringComparison.OrdinalIgnoreCase) && user.ManagerProfile == null)
                {
                    user.ManagerProfile = new ManagerProfile { Id = user.Id };
                }
            }

            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Create(CreateUserRequest request, Guid currentUserId)
        {
            // 1. Validate email and username uniqueness
            var existingUser = await _userRepository.FindUserByEmailOrUsernameAsync(request.Username, request.Email);
            if (existingUser != null)
            {
                throw new BusinessRuleException("Username or Email already exists.");
            }

            // 2. Perform Role checks - Cannot grant Admin role (ID = 1)
            if (request.RoleIds.Contains(1))
            {
                throw new BusinessRuleException("Cannot grant the Admin role to a new user.");
            }

            // 3. Hash password
            var hashedPassword = Utils.PasswordHasher.HashPassword(request.Password);

            // 4. Create User entity
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email,
                Password = hashedPassword,
                FullName = request.FullName,
                Phone = request.Phone,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                IsActive = request.IsActive,
                IsDeleted = false,
                CreatedBy = currentUserId,
                UpdatedAt = DateTime.UtcNow,
                UpdatedBy = currentUserId
            };

            // 5. Add roles
            foreach (var rId in request.RoleIds)
            {
                var role = await _roleRepository.FindRoleById(rId);
                if (role != null)
                {
                    newUser.Roles.Add(role);
                }
            }

            // 6. Ensure profile records exist for assigned roles
            foreach (var role in newUser.Roles)
            {
                if (role.Name.Equals("Student", StringComparison.OrdinalIgnoreCase))
                {
                    newUser.StudentProfile = new StudentProfile { Id = newUser.Id };
                }
                else if (role.Name.Equals("Parent", StringComparison.OrdinalIgnoreCase))
                {
                    newUser.ParentProfile = new ParentProfile { Id = newUser.Id };
                }
                else if ((role.Name.Equals("Teacher", StringComparison.OrdinalIgnoreCase) || role.Name.Equals("Instructor", StringComparison.OrdinalIgnoreCase)))
                {
                    newUser.InstructorProfile = new InstructorProfile { Id = newUser.Id };
                }
                else if (role.Name.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                {
                    newUser.ManagerProfile = new ManagerProfile { Id = newUser.Id };
                }
            }

            await _userRepository.AddAsync(newUser);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
