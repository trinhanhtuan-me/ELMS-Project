using Application.Dtos.Course;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ICourseService
    {
        Task<bool> CreateCourseAsync(CreateCourseRequest request, System.IO.Stream? thumbnailStream, string? originalFileName, System.Guid createdBy);
        Task<System.Collections.Generic.List<Domain.Entities.Course>> GetCoursesByInstructorAsync(System.Guid instructorId);
    }
}
