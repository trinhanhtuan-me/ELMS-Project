using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class EnrollmentRepository(ElmsDbContext _context) : IEnrollmentRepository
    {
        public async Task<bool> IsStudentEnroll(Guid studentId, Guid courseId)
        {
            return await _context.Enrollments.AnyAsync(e => e.StudentId == studentId && e.CourseId == courseId);
        }
    }
}
