using Application.Dtos.TeacherEvaluation;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class TeacherEvaluationRepository : ITeacherEvaluationRepository
    {
        private readonly ElmsDbContext _context;

        public TeacherEvaluationRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<(List<TeacherOverviewDto> Items, int TotalCount)> GetTeacherOverviewsAsync(TeacherEvaluationFilterRequest request)
        {
            var baseQuery = _context.InstructorProfiles
                .Include(i => i.IdNavigation)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Reviews)
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.Trim().ToLower();
                baseQuery = baseQuery.Where(i =>
                    (i.IdNavigation != null && i.IdNavigation.FullName != null && i.IdNavigation.FullName.ToLower().Contains(term)) ||
                    (i.IdNavigation != null && i.IdNavigation.Username != null && i.IdNavigation.Username.ToLower().Contains(term)) ||
                    (i.IdNavigation != null && i.IdNavigation.Email != null && i.IdNavigation.Email.ToLower().Contains(term)) ||
                    (i.Expertise != null && i.Expertise.ToLower().Contains(term)));
            }

            var rawTeachers = await baseQuery.Select(i => new
            {
                TeacherId = i.Id,
                TeacherName = i.IdNavigation != null ? (i.IdNavigation.FullName ?? i.IdNavigation.Username ?? "Giáo viên") : "Giáo viên",
                Email = i.IdNavigation != null ? (i.IdNavigation.Email ?? "") : "",
                Avatar = i.IdNavigation != null ? i.IdNavigation.Avatar : null,
                Bio = i.Bio,
                Expertise = i.Expertise,
                TotalCourses = i.Courses != null ? i.Courses.Count(c => !c.IsDeleted) : 0,
                Reviews = i.Courses != null ? i.Courses.Where(c => !c.IsDeleted && c.Reviews != null).SelectMany(c => c.Reviews).ToList() : new List<Domain.Entities.Review>()
            }).ToListAsync();

            var list = rawTeachers.Select(t =>
            {
                var reviewsList = t.Reviews ?? new List<Domain.Entities.Review>();
                int totalReviews = reviewsList.Count;
                double avgRating = totalReviews > 0 ? Math.Round(reviewsList.Average(r => (double)r.Rating), 1) : 0;

                return new TeacherOverviewDto
                {
                    TeacherId = t.TeacherId,
                    TeacherName = t.TeacherName,
                    Email = t.Email,
                    Avatar = t.Avatar,
                    Bio = t.Bio,
                    Expertise = t.Expertise,
                    TotalCourses = t.TotalCourses,
                    TotalReviews = totalReviews,
                    AverageRating = avgRating,
                    Star5Count = reviewsList.Count(r => r.Rating == 5),
                    Star4Count = reviewsList.Count(r => r.Rating == 4),
                    Star3Count = reviewsList.Count(r => r.Rating == 3),
                    Star2Count = reviewsList.Count(r => r.Rating == 2),
                    Star1Count = reviewsList.Count(r => r.Rating == 1)
                };
            }).ToList();

            if (request.MinRating.HasValue)
            {
                list = list.Where(t => t.AverageRating >= request.MinRating.Value).ToList();
            }

            list = request.SortBy switch
            {
                "rating_asc" => list.OrderBy(t => t.AverageRating).ThenByDescending(t => t.TotalReviews).ToList(),
                "reviews_desc" => list.OrderByDescending(t => t.TotalReviews).ThenByDescending(t => t.AverageRating).ToList(),
                "courses_desc" => list.OrderByDescending(t => t.TotalCourses).ThenByDescending(t => t.AverageRating).ToList(),
                _ => list.OrderByDescending(t => t.AverageRating).ThenByDescending(t => t.TotalReviews).ToList()
            };

            int totalCount = list.Count;
            int pageNum = request.PageNumber > 0 ? request.PageNumber : 1;
            int pageSize = request.PageSize > 0 ? request.PageSize : 10;

            var pagedItems = list
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return (pagedItems, totalCount);
        }

        public async Task<TeacherDetailEvaluationDto?> GetTeacherDetailAsync(Guid teacherId)
        {
            var teacher = await _context.InstructorProfiles
                .Include(i => i.IdNavigation)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Category)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Reviews)
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.Id == teacherId);

            if (teacher == null) return null;

            var validCourses = teacher.Courses != null ? teacher.Courses.Where(c => !c.IsDeleted).ToList() : new List<Domain.Entities.Course>();
            var allReviews = validCourses.SelectMany(c => c.Reviews ?? new List<Domain.Entities.Review>()).ToList();

            var courseSummaries = validCourses.Select(c => new TeacherCourseSummaryDto
            {
                CourseId = c.Id,
                CourseTitle = c.Title ?? "Khóa học",
                Thumbnail = c.Thumbnail,
                CategoryName = c.Category != null ? c.Category.Name : "Chưa phân loại",
                Status = c.Status.ToString(),
                TotalReviews = c.Reviews != null ? c.Reviews.Count : 0,
                AverageRating = (c.Reviews != null && c.Reviews.Count > 0) ? Math.Round(c.Reviews.Average(r => (double)r.Rating), 1) : 0
            }).OrderByDescending(c => c.AverageRating).ToList();

            int totalReviews = allReviews.Count;
            double avgRating = totalReviews > 0 ? Math.Round(allReviews.Average(r => (double)r.Rating), 1) : 0;

            return new TeacherDetailEvaluationDto
            {
                TeacherId = teacher.Id,
                TeacherName = teacher.IdNavigation != null ? (teacher.IdNavigation.FullName ?? teacher.IdNavigation.Username ?? "Giáo viên") : "Giáo viên",
                Email = teacher.IdNavigation != null ? (teacher.IdNavigation.Email ?? "") : "",
                Avatar = teacher.IdNavigation != null ? teacher.IdNavigation.Avatar : null,
                Bio = teacher.Bio,
                Expertise = teacher.Expertise,
                TotalCourses = validCourses.Count,
                TotalReviews = totalReviews,
                AverageRating = avgRating,
                Star5Count = allReviews.Count(r => r.Rating == 5),
                Star4Count = allReviews.Count(r => r.Rating == 4),
                Star3Count = allReviews.Count(r => r.Rating == 3),
                Star2Count = allReviews.Count(r => r.Rating == 2),
                Star1Count = allReviews.Count(r => r.Rating == 1),
                Courses = courseSummaries
            };
        }

        public async Task<(List<TeacherReviewDetailDto> Items, int TotalCount)> GetTeacherReviewsAsync(Guid teacherId, TeacherReviewFilterRequest request)
        {
            var query = _context.Reviews
                .Include(r => r.Course)
                .Include(r => r.Student)
                    .ThenInclude(s => s.IdNavigation)
                .Where(r => r.Course != null && r.Course.CreatedBy == teacherId && !r.Course.IsDeleted)
                .AsNoTracking();

            if (request.CourseId.HasValue && request.CourseId.Value != Guid.Empty)
            {
                query = query.Where(r => r.CourseId == request.CourseId.Value);
            }

            if (request.Rating.HasValue && request.Rating.Value > 0)
            {
                query = query.Where(r => r.Rating == request.Rating.Value);
            }

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                var term = request.SearchTerm.Trim().ToLower();
                query = query.Where(r =>
                    (r.Comment != null && r.Comment.ToLower().Contains(term)) ||
                    (r.Student != null && r.Student.IdNavigation != null && r.Student.IdNavigation.FullName != null && r.Student.IdNavigation.FullName.ToLower().Contains(term)) ||
                    (r.Student != null && r.Student.IdNavigation != null && r.Student.IdNavigation.Username != null && r.Student.IdNavigation.Username.ToLower().Contains(term)) ||
                    (r.Course != null && r.Course.Title != null && r.Course.Title.ToLower().Contains(term)));
            }

            int totalCount = await query.CountAsync();
            int pageNum = request.PageNumber > 0 ? request.PageNumber : 1;
            int pageSize = request.PageSize > 0 ? request.PageSize : 10;

            var items = await query
                .OrderByDescending(r => r.CreatedAt)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new TeacherReviewDetailDto
                {
                    ReviewId = r.Id,
                    CourseId = r.CourseId,
                    CourseTitle = r.Course != null ? r.Course.Title : "Khóa học",
                    StudentId = r.StudentId,
                    StudentName = r.Student != null && r.Student.IdNavigation != null ? (r.Student.IdNavigation.FullName ?? r.Student.IdNavigation.Username ?? "Học viên") : "Học viên",
                    StudentAvatar = r.Student != null && r.Student.IdNavigation != null ? r.Student.IdNavigation.Avatar : null,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    CreatedAt = r.CreatedAt
                })
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<TeacherEvaluationStatsDto> GetSystemStatsAsync()
        {
            var totalTeachers = await _context.InstructorProfiles.CountAsync();
            var allReviews = await _context.Reviews.AsNoTracking().ToListAsync();

            int totalReviews = allReviews.Count;
            double avgRating = totalReviews > 0 ? Math.Round(allReviews.Average(r => (double)r.Rating), 1) : 0;

            var teacherRatings = await _context.InstructorProfiles
                .Include(i => i.IdNavigation)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Reviews)
                .AsNoTracking()
                .Select(i => new
                {
                    Name = i.IdNavigation != null ? (i.IdNavigation.FullName ?? i.IdNavigation.Username ?? "Giáo viên") : "Giáo viên",
                    Reviews = i.Courses != null ? i.Courses.Where(c => !c.IsDeleted && c.Reviews != null).SelectMany(c => c.Reviews).ToList() : new List<Domain.Entities.Review>()
                })
                .ToListAsync();

            var topTeacher = teacherRatings
                .Where(t => t.Reviews != null && t.Reviews.Count > 0)
                .Select(t => new
                {
                    t.Name,
                    Avg = Math.Round(t.Reviews.Average(r => (double)r.Rating), 1)
                })
                .OrderByDescending(t => t.Avg)
                .FirstOrDefault();

            return new TeacherEvaluationStatsDto
            {
                TotalTeachers = totalTeachers,
                TotalSystemReviews = totalReviews,
                SystemAverageRating = avgRating,
                TopRatedTeacherName = topTeacher?.Name ?? "Chưa có",
                TopRatedTeacherRating = topTeacher?.Avg ?? 0
            };
        }
    }
}
