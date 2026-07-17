using Application.Dtos.CourseReview;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ReviewRepository(ElmsDbContext _context) : IReviewRepository
    {
        public async Task<List<ReviewDto>> GetListReview(Guid courseId, int? rating, int pageNumber, int pageSize)
        {
            var query = _context.Reviews
                .Where(r => r.CourseId == courseId);

            if (rating.HasValue)
            {
                query = query.Where(r => r.Rating == rating);
            }

            query = query.OrderByDescending(r => r.CreatedAt);

            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return await query.Select(r => new ReviewDto(
                r.Student.IdNavigation.FullName ?? r.Student.IdNavigation.Username,
                r.Rating,
                r.CreatedAt,
                r.Comment
                )).ToListAsync();
        }
        public async Task<int> CountListReview(Guid courseId, int? rating)
        {
            var query = _context.Reviews
               .Where(r => r.CourseId == courseId);

            if (rating.HasValue)
            {
                query = query.Where(r => r.Rating == rating);
            }

            return await query.CountAsync();
        }

        public async Task<ReviewSummaryDto> GetReviewSummary(Guid courseId)
        {
            var summary = await _context.Reviews
                 .Where(r => r.CourseId == courseId)
                 .GroupBy(r => 1) // cố tình group chung key = 1 để count và average
                 .Select(g => new ReviewSummaryDto(
                     g.Count(),
                     g.Average(r => (double)r.Rating),
                     g.Count(r => r.Rating == 5),
                     g.Count(r => r.Rating == 4),
                     g.Count(r => r.Rating == 3),
                     g.Count(r => r.Rating == 2),
                     g.Count(r => r.Rating == 1)
                 ))
                 .FirstOrDefaultAsync();

            return summary ?? new ReviewSummaryDto(0, 0.0, 0, 0, 0, 0, 0);
        }

        public async Task<bool> HasReviewedCourseAsync(Guid studentId, Guid courseId)
        {
            return await _context.Reviews.AnyAsync(r => r.StudentId == studentId && r.CourseId == courseId);
        }

        public async Task CreateReview(Review review)
        {
            await _context.Reviews.AddAsync(review);
        }

        public async Task<Review?> GetReview(Guid studentId, Guid courseId)
        {
            return await _context.Reviews.FirstOrDefaultAsync(r => r.StudentId == studentId && r.CourseId == courseId);
        }
    }
}
