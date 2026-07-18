using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ElmsDbContext _context;

        public CourseRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Course course)
        {
            await _context.Courses.AddAsync(course);
        }

        public async Task<List<Course>> GetByInstructorIdAsync(Guid instructorId)
        {
            return await _context.Courses
                .Where(c => c.CreatedBy == instructorId && !c.IsDeleted)
                .ToListAsync();
        }

        public async Task<Course?> GetByIdAsync(Guid id)
        {
            return await _context.Courses
                .Where(c => c.Id == id && !c.IsDeleted)
                .FirstOrDefaultAsync();
        }

        public async Task<Course?> GetWithModulesByIdAsync(Guid id, Guid instructorId)
        {
            var course = await _context.Courses
         .Include(c => c.Modules)
         .Where(c => c.Id == id && c.CreatedBy == instructorId && !c.IsDeleted)
         .FirstOrDefaultAsync();

            if (course != null && course.Modules != null)
            {

                course.Modules = course.Modules.OrderBy(m => m.OrderIndex).ToList();
            }

            return course;
        }

        public void Update(Course course)
        {
            _context.Courses.Update(course);
        }

        public async Task<Course?> GetSyllabusForStudentAsync(Guid courseId, Guid studentId)
        {
            return await _context.Courses
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Progresses.Where(p => p.StudentId == studentId))
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Lesson)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Quiz)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Assignment)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Discussion)
                .Where(c => c.Id == courseId && !c.IsDeleted)
                .FirstOrDefaultAsync();
        }
    }
}