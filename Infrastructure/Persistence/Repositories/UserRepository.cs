using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository(ElmsDbContext _context) : IUserRepository
    {
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User?> FindByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User?> FindUserByEmailOrUsernameAsync(string username, string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email || u.Username == username && !u.IsDeleted);
        }

        public async Task<User?> FindUserLoginAsync(string identifier)
        {
            return await _context.Users.Include(u => u.Roles)
                .FirstOrDefaultAsync(u => (u.Username == identifier || u.Email == identifier) && !u.IsDeleted);
        }

        public async Task<User?> FindUserByIdAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
        }

        public async Task<List<User>> GetListUsersAsync(string? searchTerm, int? roleId, bool? isActive, int pageNumber, int pageSize)
        {
            var query = _context.Users.Include(u => u.Roles).AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(u => u.Username.Contains(searchTerm) 
                                      || u.Email.Contains(searchTerm) 
                                      || (u.FullName != null && u.FullName.Contains(searchTerm)));
            }

            if (roleId.HasValue)
            {
                query = query.Where(u => u.Roles.Any(r => r.Id == roleId.Value));
            }

            if (isActive.HasValue)
            {
                query = query.Where(u => u.IsActive == isActive.Value);
            }

            return await query
                .Where(u => !u.IsDeleted)
                .OrderBy(u => u.Username)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> CountAsync(string? searchTerm, int? roleId, bool? isActive)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(u => u.Username.Contains(searchTerm) 
                                      || u.Email.Contains(searchTerm) 
                                      || (u.FullName != null && u.FullName.Contains(searchTerm)));
            }

            if (roleId.HasValue)
            {
                query = query.Where(u => u.Roles.Any(r => r.Id == roleId.Value));
            }

            if (isActive.HasValue)
            {
                query = query.Where(u => u.IsActive == isActive.Value);
            }

            return await query.CountAsync(u => !u.IsDeleted);
        }

        public async Task<User?> FindUserWithRolesByIdAsync(Guid id)
        {
            return await _context.Users
                .Include(u => u.Roles)
                .Include(u => u.StudentProfile)
                .Include(u => u.ParentProfile)
                .Include(u => u.InstructorProfile)
                .Include(u => u.ManagerProfile)
                .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
        }

    }
}
