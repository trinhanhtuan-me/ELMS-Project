using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Dtos.InstructorAssignment;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IInstructorAssignmentService
    {
        Task<PagedResult<InstructorAssignmentWorkDto>> GetPagedSubmittedAssignmentsAsync(Guid instructorId, int pageIndex, int pageSize);
        Task<InstructorAssignmentWorkDto?> GetAssignmentWorkDetailsAsync(Guid assignmentId, Guid studentId, Guid instructorId);
        Task<bool> GradeAssignmentAsync(GradeAssignmentDto dto, Guid instructorId);
    }

    public class InstructorAssignmentService : IInstructorAssignmentService
    {
        private readonly IInstructorAssignmentRepository _assignmentRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IUnitOfWork _uow;

        public InstructorAssignmentService(IInstructorAssignmentRepository assignmentRepository, IEnrollmentRepository enrollmentRepository, IUnitOfWork uow)
        {
            _assignmentRepository = assignmentRepository;
            _enrollmentRepository = enrollmentRepository;
            _uow = uow;
        }

        public async Task<PagedResult<InstructorAssignmentWorkDto>> GetPagedSubmittedAssignmentsAsync(Guid instructorId, int pageIndex, int pageSize)
        {
            return await _assignmentRepository.GetPagedSubmittedAssignmentsAsync(instructorId, pageIndex, pageSize);
        }

        public async Task<InstructorAssignmentWorkDto?> GetAssignmentWorkDetailsAsync(Guid assignmentId, Guid studentId, Guid instructorId)
        {
            return await _assignmentRepository.GetAssignmentWorkDetailsAsync(assignmentId, studentId, instructorId);
        }

        public async Task<bool> GradeAssignmentAsync(GradeAssignmentDto dto, Guid instructorId)
        {
            var aw = await _assignmentRepository.GetAssignmentWorkEntityAsync(dto.AssignmentId, dto.StudentId, instructorId);

            if (aw == null)
            {
                return false;
            }

            // Update grade
            aw.Score = dto.Score;
            aw.FeedbackText = dto.Feedback;
            aw.GradedAt = DateTime.UtcNow;
            aw.GraderId = instructorId;
            
            var passScore = aw.Assignment.MaxScore * (aw.Assignment.PassingScorePct / 100m);
            if (dto.Score >= passScore)
            {
                aw.Status = AssignmentWorkStatus.Passed;
            }
            else
            {
                aw.Status = AssignmentWorkStatus.Returned;
            }

            await _assignmentRepository.UpdateAssignmentWorkAsync(aw);
            await _uow.SaveChangeAsync();

            await _enrollmentRepository.CheckAndUpdateCourseCompletionByModuleItemIdAsync(dto.StudentId, dto.AssignmentId);

            return true;
        }
    }
}
