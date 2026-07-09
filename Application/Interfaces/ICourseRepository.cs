using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICourseRepository
    {
        Task AddAsync(Course course);
        Task<System.Collections.Generic.List<Course>> GetByInstructorIdAsync(Guid instructorId);
    }
}
