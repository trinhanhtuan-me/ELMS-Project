using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class EnrollmentRepository(ElmsDbContext context) : IEnrollmentRepository
    {
        public async Task<bool> IsEnrolledAsync(Guid courseId, Guid studentId)
        {
            return await context.Enrollments
                .AnyAsync(e => e.CourseId == courseId && e.StudentId == studentId);
        }

        public async Task<bool> IsStudentEnroll(Guid studentId, Guid courseId)
        {
            return await context.Enrollments
                .AnyAsync(e => e.StudentId == studentId && e.CourseId == courseId);
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

        public async Task<List<Enrollment>> GetByStudentIdWithCourseAsync(Guid studentId)
        {
            return await context.Enrollments
                .Include(e => e.Course)
                .Where(e => e.StudentId == studentId)
                .ToListAsync();
        }

        public async Task<List<Progress>> GetProgressByStudentAndCourseAsync(Guid studentId, Guid courseId)
        {
            return await context.Progresses
                .Include(p => p.ModuleItem)
                .Where(p => p.StudentId == studentId && p.ModuleItem.Module.CourseId == courseId)
                .ToListAsync();
        }

        public async Task<List<Module>> GetModulesWithItemsAndProgressAsync(Guid studentId, Guid courseId)
        {
            return await context.Modules
                .Include(m => m.ModuleItems.OrderBy(mi => mi.OrderIndex))
                    .ThenInclude(mi => mi.Progresses.Where(p => p.StudentId == studentId))
                .Where(m => m.CourseId == courseId)
                .OrderBy(m => m.OrderIndex)
                .ToListAsync();
        }
    }
}

