using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class InstructorProfileRepository : IInstructorProfileRepository
    {
        private readonly ElmsDbContext _context;

        public InstructorProfileRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<InstructorProfile?> GetByIdAsync(Guid instructorId)
        {
            return await _context.InstructorProfiles
                .Include(p => p.IdNavigation) // User Entity
                .FirstOrDefaultAsync(p => p.Id == instructorId);
        }

        public async Task UpdateAsync(InstructorProfile instructorProfile)
        {
            _context.InstructorProfiles.Update(instructorProfile);
            await _context.SaveChangesAsync();
        }
    }
}
