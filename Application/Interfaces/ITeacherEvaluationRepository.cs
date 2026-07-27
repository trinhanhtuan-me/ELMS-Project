using Application.Dtos.TeacherEvaluation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITeacherEvaluationRepository
    {
        Task<(List<TeacherOverviewDto> Items, int TotalCount)> GetTeacherOverviewsAsync(TeacherEvaluationFilterRequest request);
        Task<TeacherDetailEvaluationDto?> GetTeacherDetailAsync(Guid teacherId);
        Task<(List<TeacherReviewDetailDto> Items, int TotalCount)> GetTeacherReviewsAsync(Guid teacherId, TeacherReviewFilterRequest request);
        Task<TeacherEvaluationStatsDto> GetSystemStatsAsync();
    }
}
