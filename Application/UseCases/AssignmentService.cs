using Application.Common.Interfaces;
using Application.Dtos.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IAssignmentService
    {
        Task<Guid?> CreateAssignmentAsync(AssignmentCreateRequest request, Guid userId);
        Task<bool> UpdateAssignmentAsync(AssignmentUpdateRequest request, Guid userId);
        Task<AssignmentUpdateRequest?> GetAssignmentForUpdateAsync(Guid lessonId);
    }

    public class AssignmentService : IAssignmentService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly IModuleItemRepository _moduleItemRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IFileStorageService _fileStorageService;
        private readonly IUnitOfWork _uow;

        public AssignmentService(
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

        public async Task<Guid?> CreateAssignmentAsync(AssignmentCreateRequest request, Guid userId)
        {
            var module = await _moduleRepository.GetByIdAsync(request.ModuleId);
            if (module == null) return null;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return null;

            var maxOrder = await _moduleItemRepository.GetMaxOrderIndexAsync(request.ModuleId);

            var moduleItem = new ModuleItem
            {
                ModuleId = request.ModuleId,
                ItemType = ModuleItemType.Assignment,
                OrderIndex = maxOrder + 1,
                CreatedBy = userId,
                UpdatedAt = DateTime.UtcNow
            };

            string? attachmentUrl = null;
            if (request.AttachmentFile != null && request.AttachmentFile.Length > 0)
            {
                var uploadResult = await _fileStorageService.SaveFileWithMetadataAsync(request.AttachmentFile, "assignments");
                attachmentUrl = uploadResult.Url;
            }

            moduleItem.Assignment = new Assignment
            {
                Title = request.Title,
                Content = request.Content,
                Instructions = request.Instructions,
                SubmissionType = request.SubmissionType,
                MaxScore = request.MaxScore,
                PassingScorePct = request.PassingScorePct,
                AttachmentUrl = attachmentUrl
            };

            await _moduleItemRepository.AddAsync(moduleItem);
            await _uow.SaveChangeAsync();

            return moduleItem.Id;
        }

        public async Task<bool> UpdateAssignmentAsync(AssignmentUpdateRequest request, Guid userId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithAssignmentAsync(request.ModuleItemId);
            if (moduleItem == null || moduleItem.Assignment == null) return false;

            var module = await _moduleRepository.GetByIdAsync(moduleItem.ModuleId);
            if (module == null) return false;

            var course = await _courseRepository.GetByIdAsync(module.CourseId);
            if (course == null || course.CreatedBy != userId) return false;

            moduleItem.Assignment.Title = request.Title;
            moduleItem.Assignment.Content = request.Content;
            moduleItem.Assignment.Instructions = request.Instructions;
            moduleItem.Assignment.SubmissionType = request.SubmissionType;
            moduleItem.Assignment.MaxScore = request.MaxScore;
            moduleItem.Assignment.PassingScorePct = request.PassingScorePct;

            if (request.AttachmentFile != null && request.AttachmentFile.Length > 0)
            {
                var uploadResult = await _fileStorageService.SaveFileWithMetadataAsync(request.AttachmentFile, "assignments");
                moduleItem.Assignment.AttachmentUrl = uploadResult.Url;
            }

            moduleItem.UpdatedAt = DateTime.UtcNow;
            await _uow.SaveChangeAsync();
            return true;
        }

        public async Task<AssignmentUpdateRequest?> GetAssignmentForUpdateAsync(Guid lessonId)
        {
            var moduleItem = await _moduleItemRepository.GetByIdWithAssignmentAsync(lessonId);
            if (moduleItem == null || moduleItem.Assignment == null || moduleItem.Module == null) return null;

            return new AssignmentUpdateRequest
            {
                ModuleItemId = lessonId,
                CourseId = moduleItem.Module.CourseId,
                ModuleId = moduleItem.ModuleId,
                ActualLessonId = moduleItem.Assignment.Id,
                Title = moduleItem.Assignment.Title,
                Content = moduleItem.Assignment.Content,
                Instructions = moduleItem.Assignment.Instructions,
                SubmissionType = moduleItem.Assignment.SubmissionType,
                MaxScore = moduleItem.Assignment.MaxScore,
                PassingScorePct = moduleItem.Assignment.PassingScorePct,
                CurrentAttachmentUrl = moduleItem.Assignment.AttachmentUrl
            };
        }
    }
}
