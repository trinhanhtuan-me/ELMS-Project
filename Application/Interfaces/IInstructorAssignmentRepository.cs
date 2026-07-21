using Application.Common.Models;
using Application.Dtos.InstructorAssignment;
using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IInstructorAssignmentRepository
    {
        Task<PagedResult<InstructorAssignmentWorkDto>> GetPagedSubmittedAssignmentsAsync(Guid instructorId, int pageIndex, int pageSize);
        Task<InstructorAssignmentWorkDto?> GetAssignmentWorkDetailsAsync(Guid assignmentId, Guid studentId, Guid instructorId);
        Task<AssignmentWork?> GetAssignmentWorkEntityAsync(Guid assignmentId, Guid studentId, Guid instructorId);
        Task UpdateAssignmentWorkAsync(AssignmentWork aw);
    }
}
