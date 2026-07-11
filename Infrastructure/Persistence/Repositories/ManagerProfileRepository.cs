using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Manager;

public class ManagerProfileRepository : IManagerProfileRepository
{
    private readonly ElmsDbContext _context;

    public ManagerProfileRepository(ElmsDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetManagerWithProfileAsync(Guid userId)
    {
        return await _context.Users
            .Include(u => u.ManagerProfile)
            .FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task UpdateManagerProfileAsync(User user, ManagerProfile profile)
    {
        _context.Users.Update(user);

        if (_context.Entry(profile).State == EntityState.Detached)
        {
            var exists = await _context.ManagerProfiles.AnyAsync(m => m.Id == profile.Id);
            if (exists)
                _context.ManagerProfiles.Update(profile);
            else
                _context.ManagerProfiles.Add(profile);
        }
    }
}
