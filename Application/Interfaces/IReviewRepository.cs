using Application.Dtos.CourseReview;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReviewRepository
    {
        Task<List<ReviewDto>> GetListReview(Guid courseId, int? rating, int pageNumber, int pageSize);
        Task<int> CountListReview(Guid courseId, int? rating);
        Task<ReviewSummaryDto> GetReviewSummary(Guid courseId);
        Task<bool> HasReviewedCourseAsync(Guid studentId, Guid courseId);
        Task CreateReview(Review review);
        Task<Review?> GetReview(Guid studentId, Guid courseId);
    }
}
