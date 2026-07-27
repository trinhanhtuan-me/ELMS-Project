using Application.Common;
using Application.Dtos.TeacherEvaluation;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITeacherEvaluationService
    {
        Task<PaginatedList<TeacherOverviewDto>> GetTeacherOverviewsAsync(TeacherEvaluationFilterRequest request);
        Task<TeacherDetailEvaluationDto?> GetTeacherDetailAsync(Guid teacherId);
        Task<PaginatedList<TeacherReviewDetailDto>> GetTeacherReviewsAsync(Guid teacherId, TeacherReviewFilterRequest request);
        Task<TeacherEvaluationStatsDto> GetSystemStatsAsync();
    }
}
