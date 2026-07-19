using Application.Common;
using Application.Dtos.ParentProgress;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases;

public interface IParentProgressService
{
    Task<List<ChildSummaryDto>> GetChildrenSummaryAsync(Guid parentId);
    Task<List<ChildCourseProgressDto>> GetChildCoursesProgressAsync(Guid parentId, Guid studentId);
    Task<List<ChildModuleProgressDto>> GetCourseDetailProgressAsync(Guid parentId, Guid studentId, Guid courseId);
}

public class ParentProgressService : IParentProgressService
{
    private readonly IStudentProfileRepository _studentRepository;
    private readonly IEnrollmentRepository _enrollmentRepository;

    public ParentProgressService(
        IStudentProfileRepository studentRepository,
        IEnrollmentRepository enrollmentRepository)
    {
        _studentRepository = studentRepository;
        _enrollmentRepository = enrollmentRepository;
    }

    public async Task<List<ChildSummaryDto>> GetChildrenSummaryAsync(Guid parentId)
    {
        var children = await _studentRepository.GetByParentIdAsync(parentId);
        var result = new List<ChildSummaryDto>();

        foreach (var child in children)
        {
            var enrollments = await _enrollmentRepository.GetByStudentIdWithCourseAsync(child.Id);
            int enrolledCount = enrollments.Count;
            int completedCoursesCount = 0;
            decimal totalProgressSum = 0;

            foreach (var enrollment in enrollments)
            {
                var progressList = await _enrollmentRepository.GetProgressByStudentAndCourseAsync(child.Id, enrollment.CourseId);
                int totalItems = progressList.Count;
                int completedItems = progressList.Count(p => p.Status == ProgressStatus.Completed);

                decimal progressPct = totalItems > 0 
                    ? Math.Round(((decimal)completedItems / totalItems) * 100, 2) 
                    : 0;

                if (progressPct >= 100)
                {
                    completedCoursesCount++;
                }
                totalProgressSum += progressPct;
            }

            decimal averageProgress = enrolledCount > 0 
                ? Math.Round(totalProgressSum / enrolledCount, 2) 
                : 0;

            result.Add(new ChildSummaryDto
            {
                StudentId = child.Id,
                StudentName = child.IdNavigation.FullName ?? child.IdNavigation.Username,
                StudentEmail = child.IdNavigation.Email,
                EnrolledCoursesCount = enrolledCount,
                CompletedCoursesCount = completedCoursesCount,
                AverageProgressPct = averageProgress
            });
        }

        return result;
    }

    public async Task<List<ChildCourseProgressDto>> GetChildCoursesProgressAsync(Guid parentId, Guid studentId)
    {
        // Security check
        var student = await _studentRepository.GetByIdAsync(studentId);
        if (student == null || student.ParentId != parentId)
        {
            throw new BusinessRuleException("Không tìm thấy thông tin con tương ứng hoặc bạn không có quyền truy cập.");
        }

        var enrollments = await _enrollmentRepository.GetByStudentIdWithCourseAsync(studentId);
        var result = new List<ChildCourseProgressDto>();

        foreach (var enrollment in enrollments)
        {
            var progressList = await _enrollmentRepository.GetProgressByStudentAndCourseAsync(studentId, enrollment.CourseId);
            int totalItems = progressList.Count;
            int completedItems = progressList.Count(p => p.Status == ProgressStatus.Completed);

            decimal progressPct = totalItems > 0 
                ? Math.Round(((decimal)completedItems / totalItems) * 100, 2) 
                : 0;

            // Average score of completed items (if they have scores)
            var scoreItems = progressList.Where(p => p.Status == ProgressStatus.Completed && p.ScorePct.HasValue).ToList();
            decimal? averageScore = scoreItems.Any() 
                ? Math.Round(scoreItems.Average(p => p.ScorePct!.Value), 2) 
                : null;

            result.Add(new ChildCourseProgressDto
            {
                CourseId = enrollment.CourseId,
                CourseTitle = enrollment.Course.Title,
                TotalItems = totalItems,
                CompletedItems = completedItems,
                ProgressPct = progressPct,
                AverageScorePct = averageScore
            });
        }

        return result;
    }

    public async Task<List<ChildModuleProgressDto>> GetCourseDetailProgressAsync(Guid parentId, Guid studentId, Guid courseId)
    {
        // Security check
        var student = await _studentRepository.GetByIdAsync(studentId);
        if (student == null || student.ParentId != parentId)
        {
            throw new BusinessRuleException("Không tìm thấy thông tin con tương ứng hoặc bạn không có quyền truy cập.");
        }

        var modules = await _enrollmentRepository.GetModulesWithItemsAndProgressAsync(studentId, courseId);
        var result = new List<ChildModuleProgressDto>();

        foreach (var module in modules)
        {
            var moduleDto = new ChildModuleProgressDto
            {
                ModuleId = module.Id,
                ModuleTitle = module.Title,
                OrderIndex = module.OrderIndex,
                Items = new List<ChildModuleItemProgressDto>()
            };

            foreach (var item in module.ModuleItems)
            {
                // Find student progress for this module item
                var progress = item.Progresses.FirstOrDefault();

                moduleDto.Items.Add(new ChildModuleItemProgressDto
                {
                    ModuleItemId = item.Id,
                    Title = GetItemTitle(item),
                    ItemType = item.ItemType.ToString(),
                    Status = progress?.Status.ToString() ?? ProgressStatus.InProgress.ToString(),
                    PercentDone = progress?.PercentDone ?? 0,
                    ScorePct = progress?.ScorePct,
                    CompletedAt = progress?.CompletedAt
                });
            }

            result.Add(moduleDto);
        }

        return result;
    }

    private string GetItemTitle(ModuleItem item)
    {
        if (item.Lesson != null) return item.Lesson.Title;
        if (item.Quiz != null) return item.Quiz.Title;
        if (item.Assignment != null) return item.Assignment.Title;
        if (item.Discussion != null) return item.Discussion.Title;
        return "Bài học không xác định";
    }
}
