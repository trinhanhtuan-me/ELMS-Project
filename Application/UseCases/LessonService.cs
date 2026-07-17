using Application.Common.Interfaces;
using Application.Dtos.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ILessonService
    {
        Task<Guid?> CreateVideoLessonAsync(VideoLessonCreateRequest request, Guid userId);
        Task<Guid?> CreateReadingLessonAsync(ReadingLessonCreateRequest request, Guid userId);
        Task<bool> UpdateVideoLessonAsync(VideoLessonUpdateRequest request, Guid userId);
        Task<bool> UpdateReadingLessonAsync(ReadingLessonUpdateRequest request, Guid userId);
        Task<VideoLessonUpdateRequest?> GetVideoLessonForUpdateAsync(Guid lessonId);
        Task<ReadingLessonUpdateRequest?> GetReadingLessonForUpdateAsync(Guid lessonId);
        Task<bool> DeleteLessonAsync(Guid moduleItemId, Guid userId);
    }

    public class LessonService : ILessonService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IFileStorageService _fileStorageService;
        private readonly IUnitOfWork _uow;

        public LessonService(
            IModuleRepository moduleRepository,
            IModuleItemRepository moduleItemRepository,
            ICourseRepository courseRepository,
            IFileStorageService fileStorageService,
            IUnitOfWork uow)
        {
            _moduleRepository = moduleRepository;
            _moduleItemRepository = moduleItemRepository;
            _courseRepository = courseRepository;
            _fileStorageService = fileStorageService;
            _uow = uow;
        }

        public async Task<Guid?> CreateVideoLessonAsync(VideoLessonCreateRequest request, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(request.ModuleId);
            if (module == null) return null;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return null;

            var uploadResult = await _fileStorageService.SaveFileWithMetadataAsync(request.VideoFile, "lessons/video");

            var maxOrder = await _moduleItemRepository.GetMaxOrderIndexAsync(request.ModuleId);

            var moduleItem = new ModuleItem
            {
                ModuleId = request.ModuleId,
                ItemType = ModuleItemType.Lesson,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            moduleItem.Lesson = new Lesson
            {
                Title = request.Title,
                ContentType = LessonContentType.Video,
                VideoUrl = uploadResult.Url,
                DurationSec = uploadResult.DurationSec.HasValue ? (int)Math.Round(uploadResult.DurationSec.Value) : 0
            };

            await _moduleItemRepository.AddAsync(moduleItem);
            await _uow.SaveChangeAsync();

            return moduleItem.Id;
        }

        public async Task<Guid?> CreateReadingLessonAsync(ReadingLessonCreateRequest request, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(request.ModuleId);
            if (module == null) return null;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return null;

            var maxOrder = await _moduleItemRepository.GetMaxOrderIndexAsync(request.ModuleId);

            var moduleItem = new ModuleItem
            {
                ModuleId = request.ModuleId,
                ItemType = ModuleItemType.Lesson,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            moduleItem.Lesson = new Lesson
            {
                Title = request.Title,
                ContentType = LessonContentType.Reading,
                TextContent = request.TextContent
            };

            await _moduleItemRepository.AddAsync(moduleItem);
            await _uow.SaveChangeAsync();

            return moduleItem.Id;
        }

        public async Task<bool> UpdateVideoLessonAsync(VideoLessonUpdateRequest request, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithLessonAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Lesson == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            moduleItem.Lesson.Title = request.Title;

            if (request.VideoFile != null && request.VideoFile.Length > 0)
            {
                var uploadResult = await _fileStorageService.SaveFileWithMetadataAsync(request.VideoFile, "lessons/video");
                moduleItem.Lesson.VideoUrl = uploadResult.Url;
                moduleItem.Lesson.DurationSec = uploadResult.DurationSec.HasValue ? (int)Math.Round(uploadResult.DurationSec.Value) : 0;
            }

            moduleItem.UpdatedAt = DateTime.UtcNow;
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> UpdateReadingLessonAsync(ReadingLessonUpdateRequest request, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithLessonAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Lesson == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            moduleItem.Lesson.Title = request.Title;
            moduleItem.Lesson.TextContent = request.TextContent;
            moduleItem.UpdatedAt = DateTime.UtcNow;

            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<bool> DeleteLessonAsync(Guid moduleItemId, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithLessonAsync(moduleItemId);
            if (moduleItem == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            _moduleItemRepository.Delete(moduleItem);
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<VideoLessonUpdateRequest?> GetVideoLessonForUpdateAsync(Guid lessonId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithLessonAsync(lessonId);
            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Module == null) return null;

            return new VideoLessonUpdateRequest
            {
                ModuleItemId = lessonId,
                CourseId = moduleItem.Module.CourseId,
                ModuleId = moduleItem.ModuleId,
                ActualLessonId = moduleItem.Lesson.Id,
                Title = moduleItem.Lesson.Title,
                CurrentVideoUrl = moduleItem.Lesson.VideoUrl
            };
        }

        public async Task<ReadingLessonUpdateRequest?> GetReadingLessonForUpdateAsync(Guid lessonId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithLessonAsync(lessonId);
            if (moduleItem == null || moduleItem.Lesson == null || moduleItem.Module == null) return null;

            return new ReadingLessonUpdateRequest
            {
                ModuleItemId = lessonId,
                CourseId = moduleItem.Module.CourseId,
                ModuleId = moduleItem.ModuleId,
                ActualLessonId = moduleItem.Lesson.Id,
                Title = moduleItem.Lesson.Title,
                TextContent = moduleItem.Lesson.TextContent ?? ""
            };
        }
    }
}
