using Application.Common;
using Application.Dtos.TeacherEvaluation;
using Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class TeacherEvaluationService : ITeacherEvaluationService
    {
        private readonly ITeacherEvaluationRepository _repository;

        public TeacherEvaluationService(ITeacherEvaluationRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedList<TeacherOverviewDto>> GetTeacherOverviewsAsync(TeacherEvaluationFilterRequest request)
        {
            var (items, totalCount) = await _repository.GetTeacherOverviewsAsync(request);
            return new PaginatedList<TeacherOverviewDto>(totalCount, items);
        }

        public async Task<TeacherDetailEvaluationDto?> GetTeacherDetailAsync(Guid teacherId)
        {
            return await _repository.GetTeacherDetailAsync(teacherId);
        }

        public async Task<PaginatedList<TeacherReviewDetailDto>> GetTeacherReviewsAsync(Guid teacherId, TeacherReviewFilterRequest request)
        {
            var (items, totalCount) = await _repository.GetTeacherReviewsAsync(teacherId, request);
            return new PaginatedList<TeacherReviewDetailDto>(totalCount, items);
        }

        public async Task<TeacherEvaluationStatsDto> GetSystemStatsAsync()
        {
            return await _repository.GetSystemStatsAsync();
        }
    }
}
