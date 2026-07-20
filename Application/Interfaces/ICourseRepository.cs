using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICourseRepository
    {
        Task AddAsync(Course course);
        Task<(List<Course> Items, int TotalCount)> GetPagedByInstructorIdAsync(Guid instructorId, string? searchTerm, int pageIndex, int pageSize);
        Task<Course?> GetByIdAsync(Guid id);
        Task<Course?> GetWithModulesByIdAsync(Guid id, Guid instructorId);
        void Update(Course course);
        Task<Course?> GetSyllabusForStudentAsync(Guid courseId, Guid studentId);

        Task<List<Course>> GetPopularCoursesAsync(int count);
        Task<List<Course>> GetNewestCoursesAsync(int count);
        Task<Course?> GetPublicCourseDetailsAsync(Guid courseId);

        Task<(List<string> Languages, List<string> Levels)> GetFilterOptionsAsync();
        Task<List<Course>> SearchCoursesAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels, string sortBy, int page, int pageSize);
        Task<int> CountSearchCoursesAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels);
    }
}