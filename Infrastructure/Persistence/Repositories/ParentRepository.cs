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
    }
}
