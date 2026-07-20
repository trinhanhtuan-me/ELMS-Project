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
    public class ParentRepository(ElmsDbContext _context) : IParentRepository
    {
        public async Task<ParentProfile?> FindByParentEmail(string email)
        {
            return await _context.ParentProfiles
                .Include(p => p.IdNavigation)
                .FirstOrDefaultAsync(u => u.IdNavigation.Email == email);
        }

        public async Task<User?> GetParentWithProfileAsync(Guid userId)
        {
            return await _context.Users
                .Include(u => u.ParentProfile)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task UpdateParentProfileAsync(User user, ParentProfile profile)
        {
            var existingProfile = await _context.ParentProfiles.FindAsync(profile.Id);
            if (existingProfile == null)
            {
                _context.ParentProfiles.Add(profile);
            }
            else
            {
                _context.Entry(existingProfile).CurrentValues.SetValues(profile);
            }
        }
    }
}
