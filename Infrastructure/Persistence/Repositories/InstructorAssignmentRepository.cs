using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Dtos.InstructorAssignment;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class InstructorAssignmentRepository : IInstructorAssignmentRepository
    {
        private readonly ElmsDbContext _context;

        public InstructorAssignmentRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<InstructorAssignmentWorkDto>> GetPagedSubmittedAssignmentsAsync(Guid instructorId, int pageIndex, int pageSize)
        {
            var query = _context.AssignmentWorks
                .Include(aw => aw.Assignment)
                    .ThenInclude(a => a.IdNavigation)
                        .ThenInclude(mi => mi.Module)
                            .ThenInclude(m => m.Course)
                .Include(aw => aw.Student)
                    .ThenInclude(s => s.IdNavigation)
                .Where(aw => aw.Assignment.IdNavigation.Module.Course.CreatedBy == instructorId 
                          && aw.Status == AssignmentWorkStatus.Submitted);

            var totalCount = await query.CountAsync();

            var items = await query
                .OrderByDescending(aw => aw.SubmittedAt)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .Select(aw => new InstructorAssignmentWorkDto
                {
                    AssignmentId = aw.AssignmentId,
                    StudentId = aw.StudentId,
                    StudentName = aw.Student.IdNavigation.FullName ?? aw.Student.IdNavigation.Username,
                    StudentEmail = aw.Student.IdNavigation.Email,
                    CourseTitle = aw.Assignment.IdNavigation.Module.Course.Title,
                    ModuleTitle = aw.Assignment.IdNavigation.Module.Title,
                    AssignmentTitle = aw.Assignment.Title,
                    TextAnswer = aw.TextAnswer,
                    FileUrl = aw.FileUrl,
                    Status = aw.Status,
                    Score = aw.Score,
                    MaxScore = aw.Assignment.MaxScore,
                    PassingScorePct = aw.Assignment.PassingScorePct,
                    SubmittedAt = aw.SubmittedAt,
                    GradedAt = aw.GradedAt
                })
                .ToListAsync();

            return new PagedResult<InstructorAssignmentWorkDto>(items, totalCount, pageIndex, pageSize);
        }

        public async Task<InstructorAssignmentWorkDto?> GetAssignmentWorkDetailsAsync(Guid assignmentId, Guid studentId, Guid instructorId)
        {
            var aw = await _context.AssignmentWorks
                .Include(aw => aw.Assignment)
                    .ThenInclude(a => a.IdNavigation)
                        .ThenInclude(mi => mi.Module)
                            .ThenInclude(m => m.Course)
                .Include(aw => aw.Student)
                    .ThenInclude(s => s.IdNavigation)
                .FirstOrDefaultAsync(aw => aw.AssignmentId == assignmentId && aw.StudentId == studentId);

            if (aw == null || aw.Assignment.IdNavigation.Module.Course.CreatedBy != instructorId)
            {
                return null;
            }

            return new InstructorAssignmentWorkDto
            {
                AssignmentId = aw.AssignmentId,
                StudentId = aw.StudentId,
                StudentName = aw.Student.IdNavigation.FullName ?? aw.Student.IdNavigation.Username,
                StudentEmail = aw.Student.IdNavigation.Email,
                CourseTitle = aw.Assignment.IdNavigation.Module.Course.Title,
                ModuleTitle = aw.Assignment.IdNavigation.Module.Title,
                AssignmentTitle = aw.Assignment.Title,
                TextAnswer = aw.TextAnswer,
                FileUrl = aw.FileUrl,
                Status = aw.Status,
                Score = aw.Score,
                MaxScore = aw.Assignment.MaxScore,
                PassingScorePct = aw.Assignment.PassingScorePct,
                SubmittedAt = aw.SubmittedAt,
                GradedAt = aw.GradedAt
            };
        }

        public async Task<AssignmentWork?> GetAssignmentWorkEntityAsync(Guid assignmentId, Guid studentId, Guid instructorId)
        {
            return await _context.AssignmentWorks
                .Include(aw => aw.Assignment)
                    .ThenInclude(a => a.IdNavigation)
                        .ThenInclude(mi => mi.Module)
                            .ThenInclude(m => m.Course)
                .FirstOrDefaultAsync(aw => aw.AssignmentId == assignmentId && aw.StudentId == studentId && aw.Assignment.IdNavigation.Module.Course.CreatedBy == instructorId);
        }

        public Task UpdateAssignmentWorkAsync(AssignmentWork aw)
        {
            _context.AssignmentWorks.Update(aw);
            return Task.CompletedTask;
        }
    }
}
