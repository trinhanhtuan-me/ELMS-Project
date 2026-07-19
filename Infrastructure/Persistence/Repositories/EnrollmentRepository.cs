using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class EnrollmentRepository(ElmsDbContext context) : IEnrollmentRepository
{
    public async Task<bool> IsEnrolledAsync(Guid courseId, Guid studentId)
    {
        return await context.Enrollments
            .AnyAsync(e => e.CourseId == courseId && e.StudentId == studentId);
    }

    public async Task AddAsync(Enrollment enrollment)
    {
        await context.Enrollments.AddAsync(enrollment);

        var moduleItems = await context.ModuleItems
            .Where(mi => mi.Module.CourseId == enrollment.CourseId)
            .ToListAsync();

        foreach (var item in moduleItems)
        {
            var progress = new Progress
            {
                StudentId = enrollment.StudentId,
                ModuleItemId = item.Id,
                Status = ProgressStatus.InProgress,
                PercentDone = 0,
                UpdatedAt = DateTime.UtcNow
            };
            await context.Progresses.AddAsync(progress);
        }
    }
}
