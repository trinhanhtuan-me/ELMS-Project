using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class StudentProfileRepository(ElmsDbContext context) : IStudentProfileRepository
{
    public async Task<StudentProfile?> GetByIdAsync(Guid studentId)
    {
        return await context.StudentProfiles.FindAsync(studentId);
    }

    public void Update(StudentProfile student)
    {
        context.StudentProfiles.Update(student);
    }

    public async Task<List<StudentProfile>> GetByParentIdAsync(Guid parentId)
    {
        return await context.StudentProfiles
            .Include(s => s.IdNavigation)
            .Where(s => s.ParentId == parentId)
            .ToListAsync();
    }
}
