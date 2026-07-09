using Application.Common.Interfaces;
using Application.Dtos.Course;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _uow;
        private readonly IFileStorageService _fileStorageService;

        public CourseService(ICourseRepository courseRepository, IUnitOfWork uow, IFileStorageService fileStorageService)
        {
            _courseRepository = courseRepository;
            _uow = uow;
            _fileStorageService = fileStorageService;
        }

        public async Task<bool> CreateCourseAsync(CreateCourseRequest request, System.IO.Stream? thumbnailStream, string? originalFileName, Guid createdBy)
        {
            string? thumbnailUrl = null;
            if (thumbnailStream != null && !string.IsNullOrEmpty(originalFileName))
            {
                thumbnailUrl = await _fileStorageService.SaveFileAsync(thumbnailStream, originalFileName, "thumbnail/course");
            }

            var course = new Course
            {
                Title = request.Title,
                Description = request.Description,
                Language = request.Language,
                Level = request.Level,
                Thumbnail = thumbnailUrl,
                CategoryId = request.CategoryId,
                Status = CourseStatus.Draft,
                CreatedBy = createdBy,
                UpdatedAt = DateTime.UtcNow
            };
            await _courseRepository.AddAsync(course);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<System.Collections.Generic.List<Course>> GetCoursesByInstructorAsync(Guid instructorId)
        {
            return await _courseRepository.GetByInstructorIdAsync(instructorId);
        }
    }
}
