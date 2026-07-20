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
    public class AssignmentRepository(ElmsDbContext _context) : IAssignmentRepository
    {
        public async Task AddAsync(AssignmentWork work)
        {
            await _context.AssignmentWorks.AddAsync(work);
        }

        public async Task<AssignmentWork?> GetByAssignmentWorkAndStudentAsync(Guid assignmentId, Guid studentId)
        {
            return await _context.AssignmentWorks
               .FirstOrDefaultAsync(w => w.AssignmentId == assignmentId && w.StudentId == studentId);
        }
    }
}
