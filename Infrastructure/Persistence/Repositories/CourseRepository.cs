using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
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

        public async Task<System.Collections.Generic.List<Course>> GetByInstructorIdAsync(System.Guid instructorId)
        {
            return await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync(
                System.Linq.Queryable.Where(_context.Courses, c => c.CreatedBy == instructorId && !c.IsDeleted));
        }
    }
}
