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

        public async Task<List<Course>> GetPopularCoursesAsync(int count)
        {
            return await _context.Courses
                .Where(c => !c.IsDeleted && c.Status == CourseStatus.Publish)
                .OrderByDescending(c => c.Enrollments.Count)
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<Course>> GetNewestCoursesAsync(int count)
        {
            return await _context.Courses
                .Where(c => !c.IsDeleted && c.Status == CourseStatus.Publish)
                .OrderByDescending(c => c.PublishAt ?? c.CreatedAt)
                .Take(count)
                .ToListAsync();
        }

        public async Task<Course?> GetPublicCourseDetailsAsync(Guid courseId)
        {
            return await _context.Courses
                .Include(c => c.CreatedByNavigation)
                    .ThenInclude(i => i.IdNavigation)
                .Include(c => c.Category)
                .Include(c => c.CoursePrice)
                .Include(c => c.Enrollments)
                .Include(c => c.CourseRequests)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Lesson)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Assignment)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Quiz)
                .Include(c => c.Modules)
                    .ThenInclude(m => m.ModuleItems)
                        .ThenInclude(mi => mi.Discussion)
                .FirstOrDefaultAsync(c => c.Id == courseId && !c.IsDeleted && c.Status == CourseStatus.Publish);
        }

        public async Task<int> CountSearchCoursesAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels)
        {
            var query = _context.Courses.Where(c => !c.IsDeleted && c.Status == CourseStatus.Publish);

            if (!string.IsNullOrWhiteSpace(keyword))
                query = query.Where(c => c.Title.Contains(keyword) || c.Description.Contains(keyword));

            if (categoryIds != null && categoryIds.Any()) query = query.Where(c => categoryIds.Contains(c.CategoryId));
            if (languages != null && languages.Any()) query = query.Where(c => languages.Contains(c.Language));
            if (levels != null && levels.Any()) query = query.Where(c => levels.Contains(c.Level));

            return await query.CountAsync();
        }

        public async Task<List<Course>> SearchCoursesAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels, string sortBy, int page, int pageSize)
        {
            var query = _context.Courses
                        .Include(c => c.Enrollments)
                        .Where(c => !c.IsDeleted && c.Status == CourseStatus.Publish);

            if (!string.IsNullOrWhiteSpace(keyword))
                query = query.Where(c => c.Title.Contains(keyword) || c.Description.Contains(keyword));

            if (categoryIds != null && categoryIds.Any()) query = query.Where(c => categoryIds.Contains(c.CategoryId));
            if (languages != null && languages.Any()) query = query.Where(c => languages.Contains(c.Language));
            if (levels != null && levels.Any()) query = query.Where(c => levels.Contains(c.Level));

            if (sortBy == "newest")
                query = query.OrderByDescending(c => c.CreatedAt);
            else
                query = query.OrderByDescending(c => c.Enrollments.Count);

            return await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<(List<string> Languages, List<string> Levels)> GetFilterOptionsAsync()
        {
            var query = _context.Courses.Where(c => !c.IsDeleted && c.Status == CourseStatus.Publish);
            var languages = await query.Select(c => c.Language).Distinct().ToListAsync();
            var levels = await query.Select(c => c.Level).Distinct().ToListAsync();
            return (languages, levels);
        }
    }
}