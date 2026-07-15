using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class StudentProfileRepository(ElmsDbContext context) : IStudentProfileRepository
{
    public async Task<StudentProfile?> GetByIdAsync(Guid studentId)
    {
        return await context.StudentProfiles
                    .Include(s => s.IdNavigation)
                    .FirstOrDefaultAsync(s => s.Id == studentId);
    }

    public void Update(StudentProfile student)
    {
        context.StudentProfiles.Update(student);
    }
}
