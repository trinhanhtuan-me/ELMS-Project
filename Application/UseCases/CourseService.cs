using Application.Common.Interfaces;
using Application.Dtos.Course;
using Application.Dtos.CourseDetail;
using Application.Exceptions;
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
        Task<List<CourseManagementResponse>> GetCoursesByInstructorAsync(Guid instructorId);
        Task<bool> UpdateCourseAsync(CourseUpsertRequest request, Guid instructorId);
        Task<bool> SoftDeleteCourseAsync(Guid id, Guid instructorId);
        Task<CourseDetailResponse?> GetCourseDetailsAsync(Guid id, Guid instructorId);
        Task<bool> SubmitCourseAsync(Guid id, Guid instructorId);
        Task<PublicCourseDetailVm?> GetPublicCourseDetailsAsync(Guid courseId, Guid? studentId);
    }

    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _uow;
        private readonly IFileStorageService _fileStorageService;
        private readonly IReviewRepository _review;

        public CourseService(ICourseRepository courseRepository, IUnitOfWork uow, IFileStorageService fileStorageService, IReviewRepository review)
        {
            _courseRepository = courseRepository;
            _uow = uow;
            _fileStorageService = fileStorageService;
            _review = review;
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

        public async Task<List<CourseManagementResponse>> GetCoursesByInstructorAsync(Guid instructorId)
        {
            var courses = await _courseRepository.GetByInstructorIdAsync(instructorId);

            
            return courses.Select(c => new CourseManagementResponse(
                c.Id,
                c.Title,
                c.Level,
                c.Language,
                c.Status,
                c.Thumbnail,
                c.CategoryId,
                c.Description
            )).ToList();
        }

        public async Task<bool> UpdateCourseAsync(CourseUpsertRequest request, Guid instructorId)
        {
            if (request.Id == null) return false;
            var course = await _courseRepository.GetByIdAsync(request.Id.Value);
            if (course == null || course.CreatedBy != instructorId) return false;

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

        public async Task<PublicCourseDetailVm?> GetPublicCourseDetailsAsync(Guid courseId, Guid? studentId)
        {
            var course = await _courseRepository.GetPublicCourseDetailsAsync(courseId);
            if (course == null) throw new BusinessRuleException("Course not found");

            var reviewSummary = await _review.GetReviewSummary(courseId);
            var reviews = await _review.GetListReview(courseId, null, 1, 4); // Lấy 4 đánh giá

            var vm = new PublicCourseDetailVm
            {
                CourseId = course.Id,
                Title = course.Title,
                Description = course.Description,
                Thumbnail = course.Thumbnail,
                InstructorName = course.CreatedByNavigation?.IdNavigation?.FullName ?? "Unknown",
                CategoryName = course.Category?.Name ?? "",
                Level = course.Level,
                Language = course.Language,

                AverageRating = reviewSummary.AverageRating,
                TotalReviews = reviewSummary.TotalReviews,
                TotalStudents = course.Enrollments.Count,
                Reviews = reviews
            };

            if (studentId.HasValue)
            {
                if (course.Enrollments.Any(e => e.StudentId == studentId.Value))
                    vm.ButtonState = "Enrolled";
                else if (course.CourseRequests.Any(r => r.StudentId == studentId.Value))
                    vm.ButtonState = "Requested";
            }

            // Đếm số lượng học liệu trong từng Module
            foreach (var mod in course.Modules.OrderBy(m => m.OrderIndex))
            {
                var modVm = new PublicModuleVm
                {
                    ModuleId = mod.Id,
                    Title = mod.Title,
                    Description = mod.Description
                };

                foreach (var item in mod.ModuleItems.OrderBy(i => i.OrderIndex))
                {
                    var itemVm = new PublicModuleItemVm();
                    switch (item.ItemType)
                    {
                        case ModuleItemType.Lesson:
                            itemVm.Title = item.Lesson?.Title ?? "";
                            if (item.Lesson?.ContentType == LessonContentType.Video)
                            {
                                itemVm.ItemType = "Video";
                                modVm.VideoCount++;
                            }
                            else
                            {
                                itemVm.ItemType = "Reading";
                                modVm.ReadingCount++;
                            }
                            break;
                        case ModuleItemType.Assignment:
                            itemVm.Title = item.Assignment?.Title ?? "";
                            itemVm.ItemType = "Assignment";
                            modVm.AssignmentCount++;
                            break;
                        case ModuleItemType.Quiz:
                            itemVm.Title = item.Quiz?.Title ?? "";
                            itemVm.ItemType = "Quiz";
                            modVm.QuizCount++;
                            break;
                        case ModuleItemType.Discussion:
                            itemVm.Title = item.Discussion?.Title ?? "";
                            itemVm.ItemType = "Discussion";
                            modVm.DiscussionCount++;
                            break;
                    }
                    modVm.Items.Add(itemVm);
                }
                vm.Modules.Add(modVm);
            }
            return vm;
        }
    }
}