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

        public async Task<User?> FindUserByEmailOrUsernameAsync(string username, string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email || u.Username == username);
        }

        public async Task<User?> FindUserLoginAsync(string identifier)
        {
            return await _context.Users.Include(u => u.Roles)
                .FirstOrDefaultAsync(u => (u.Username == identifier || u.Email == identifier) && !u.IsDeleted);
        }
    }
}
