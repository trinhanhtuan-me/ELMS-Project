using Application.Common.Interfaces;
using Application.Dtos.Course;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ICourseService
    {
        Task<bool> CreateCourseAsync(CourseUpsertRequest request, Guid createdBy);
        Task<Application.Common.Models.PagedResult<CourseManagementResponse>> GetPagedCoursesByInstructorAsync(Guid instructorId, string? searchTerm, int pageIndex, int pageSize);
        Task<bool> UpdateCourseAsync(CourseUpsertRequest request, Guid instructorId);
        Task<bool> SoftDeleteCourseAsync(Guid id, Guid instructorId);
        Task<CourseDetailResponse?> GetCourseDetailsAsync(Guid id, Guid instructorId);
        Task<bool> SubmitCourseAsync(Guid id, Guid instructorId);
    }

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

        public async Task<bool> CreateCourseAsync(CourseUpsertRequest request, Guid createdBy)
        {
            string? thumbnailUrl = null;
            if (request.ThumbnailFile != null && request.ThumbnailFile.Length > 0)
            {
               
                thumbnailUrl = await _fileStorageService.SaveFileAsync(request.ThumbnailFile, "thumbnail/course");
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



        public async Task<Application.Common.Models.PagedResult<CourseManagementResponse>> GetPagedCoursesByInstructorAsync(Guid instructorId, string? searchTerm, int pageIndex, int pageSize)
        {
            var (items, totalCount) = await _courseRepository.GetPagedByInstructorIdAsync(instructorId, searchTerm, pageIndex, pageSize);

            var dtos = items.Select(c => new CourseManagementResponse(
                c.Id,
                c.Title,
                c.Level,
                c.Language,
                c.Status,
                c.Thumbnail,
                c.CategoryId,
                c.Description
            )).ToList();

            return new Application.Common.Models.PagedResult<CourseManagementResponse>(dtos, totalCount, pageIndex, pageSize);
        }

        public async Task<bool> UpdateCourseAsync(CourseUpsertRequest request, Guid instructorId)
        {
            if (request.Id == null) return false;
            var course = await _courseRepository.GetByIdAsync(request.Id.Value);
            if (course == null || course.CreatedBy != instructorId) return false;
            if (course.Status != CourseStatus.Draft && course.Status != CourseStatus.Rejected) return false;

            if (request.ThumbnailFile != null && request.ThumbnailFile.Length > 0)
            {
                course.Thumbnail = await _fileStorageService.SaveFileAsync(request.ThumbnailFile, "thumbnail/course");
            }
            else
            {
                course.Thumbnail = request.ThumbnailUrl;
            }

            course.Title = request.Title;
            course.Description = request.Description;
            course.Language = request.Language;
            course.Level = request.Level;
            course.CategoryId = request.CategoryId;
            course.UpdatedAt = DateTime.UtcNow;
            course.UpdatedBy = instructorId;

            _courseRepository.Update(course);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<CourseDetailResponse?> GetCourseDetailsAsync(Guid id, Guid instructorId)
        {
            var course = await _courseRepository.GetWithModulesByIdAsync(id, instructorId);
            if (course == null) return null;

            
            return new CourseDetailResponse(
                course.Id,
                course.Title,
                course.Description,
                course.Thumbnail,
                course.Modules.ToList()
            );
        }

        public async Task<bool> SoftDeleteCourseAsync(Guid id, Guid instructorId)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null || course.CreatedBy != instructorId) return false;
            if (course.Status != CourseStatus.Draft && course.Status != CourseStatus.Rejected) return false;

            course.IsDeleted = true;
            course.UpdatedAt = DateTime.UtcNow;
            course.UpdatedBy = instructorId;

            _courseRepository.Update(course);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> SubmitCourseAsync(Guid id, Guid instructorId)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null || course.CreatedBy != instructorId || course.Status != CourseStatus.Draft) return false;

            course.Status = CourseStatus.Submitted;
            course.UpdatedAt = DateTime.UtcNow;
            course.UpdatedBy = instructorId;

            _courseRepository.Update(course);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}