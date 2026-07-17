using Application.Common.Interfaces;
using Application.Dtos.CourseReview;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ICourseReviewService
    {
        Task<GetListReviewResponse> GetListCourseReview(GetListReviewRequest request);
        Task CreateCourseReview(Guid studentId, CreateReviewRequest request);
        Task UpdateCourseReview(Guid studentId, UpdateReviewRequest request);
        Task<ReviewDto?> GetMyReview(Guid studentId, Guid courseId);
    }

    public class CourseReviewService : ICourseReviewService
    {
        private readonly IUnitOfWork _uow;
        private readonly IReviewRepository _review;
        private readonly IEnrollmentRepository _enroll;
        private readonly IStudentProfileRepository _student;
        public CourseReviewService(IUnitOfWork uow, IReviewRepository review, IEnrollmentRepository enroll, IStudentProfileRepository student)
        {
            _uow = uow;
            _review = review;
            _enroll = enroll;
            _student = student;
        }

        public async Task<GetListReviewResponse> GetListCourseReview(GetListReviewRequest request)
        {
            var count = await _review.CountListReview(request.CourseId, request.Rating);
            var list = await _review.GetListReview(request.CourseId, request.Rating, request.PageNumber, request.PageSize);
            var summary = await _review.GetReviewSummary(request.CourseId);

            int totalPages = count == 0 ? 0 : (int)Math.Ceiling(count / (double)request.PageSize);

            return new GetListReviewResponse(
                request.Rating,
                request.PageNumber,
                totalPages,
                summary,
                list
            );
        }

        public async Task CreateCourseReview(Guid studentId, CreateReviewRequest request)
        {
            var isEnroll = await _enroll.IsStudentEnroll(studentId, request.CourseId);
            if (!isEnroll) throw new BusinessRuleException("Please enroll this course before sending review");
            var hasReviewed = await _review.HasReviewedCourseAsync(studentId, request.CourseId);
            if (hasReviewed) throw new BusinessRuleException("You have already reviewed this course.");
            var newReview = new Domain.Entities.Review

            {
                CourseId = request.CourseId,
                StudentId = studentId,
                Rating = (byte)request.Rating,
                Comment = request.Comment,
            };

            await _review.CreateReview(newReview);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateCourseReview(Guid studentId, UpdateReviewRequest request)
        {
            var existingReview = await _review.GetReview(studentId, request.CourseId);

            if (existingReview == null) throw new BusinessRuleException("Review not found.");

            existingReview.Rating = (byte)request.Rating;
            existingReview.Comment = request.Comment;
            existingReview.LastUpdatedAt = DateTime.Now;

            await _uow.SaveChangeAsync();
        }

        public async Task<ReviewDto?> GetMyReview(Guid studentId, Guid courseId)
        {
            var review = await _review.GetReview(studentId, courseId);

            if (review == null) return null;

            return new ReviewDto(
                string.Empty,
                review.Rating,
                review.CreatedAt,
                review.Comment
            );
        }
    }
}
