using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICourseRepository
    {
        Task AddAsync(Course course);
        Task<List<Course>> GetByInstructorIdAsync(Guid instructorId);
        Task<Course?> GetByIdAsync(Guid id);
        Task<Course?> GetWithModulesByIdAsync(Guid id, Guid instructorId);
        void Update(Course course);
        Task<Course?> GetSyllabusForStudentAsync(Guid courseId, Guid studentId);
    }
}