using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseReview
{
    public record GetListReviewRequest(Guid CourseId, int? Rating, int PageSize = 5, int PageNumber = 1);

    public record GetListReviewResponse(
        int? Rating,
        int CurrentPage,
        int TotalPages,
        ReviewSummaryDto Summary,
        List<ReviewDto> ListReview
        );
    public record ReviewSummaryDto(int TotalReviews, double AverageRating, int FiveCount, int FourCount, int ThreeCount, int TwoCount, int OneCount);
    public record ReviewDto(
        string StudentName,
        int Rating,
        DateTime ReviewDate,
        string Comment
        );
}
