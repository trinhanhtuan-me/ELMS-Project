using Application.Dtos.Manager;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ManagerDashboardRepository(ElmsDbContext _context) : IManagerDashboardRepository
    {
        public async Task<int> GetTotalCoursesAsync()
        {
            return await _context.Courses.CountAsync(c => !c.IsDeleted);
        }

        public async Task<int> GetTotalInstructorsAsync()
        {
            return await _context.Users.CountAsync(u => !u.IsDeleted && u.InstructorProfile != null);
        }

        public async Task<int> GetPendingCoursesAsync()
        {
            return await _context.Courses.CountAsync(c => !c.IsDeleted && c.Status == CourseStatus.Submitted);
        }

        public async Task<decimal> GetTotalRevenue30dAsync()
        {
            var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30);

            var total = await _context.Payments
                .Where(p => p.CapturedAt >= thirtyDaysAgo && p.Status == PaymentStatus.Captured)
                .SumAsync(p => (decimal?)p.AmountVnd);
            return total ?? 0m;
        }

        public async Task<List<MonthlyRevenueVm>> GetMonthlyRevenueAsync(int year)
        {
            var payments = await _context.Payments
                .Where(p => p.CapturedAt != null
                         && p.CapturedAt.Value.Year == year
                         && p.Status == PaymentStatus.Captured)
                .Select(p => new { p.CapturedAt, p.AmountVnd })
                .ToListAsync();

            var revenueByMonth = payments
                .GroupBy(p => p.CapturedAt!.Value.Month)
                .Select(g => new MonthlyRevenueVm(
                    Month: g.Key,
                    Year: year,
                    TotalRevenue: g.Sum(x => x.AmountVnd)
                ))
                .ToList();

            // Fill đủ 12 tháng
            var fullYearRevenue = Enumerable.Range(1, 12).Select(month =>
            {
                var match = revenueByMonth.FirstOrDefault(r => r.Month == month);
                return match ?? new MonthlyRevenueVm(month, year, 0);
            }).ToList();
            return fullYearRevenue;
        }

        public async Task<Dictionary<string, int>> GetCourseStatusCountsAsync()
        {
            var statusCounts = await _context.Courses
                .Where(c => !c.IsDeleted && c.Status != CourseStatus.Draft)
                .GroupBy(c => c.Status)
                .Select(g => new { Status = g.Key.ToString(), Count = g.Count() })
                .ToDictionaryAsync(k => k.Status, v => v.Count);

            return statusCounts;
        }

        public async Task<List<DashboardCourseRowVm>> GetApprovedRejectedCoursesAsync()
        {
            return await _context.Courses
                .Where(c => !c.IsDeleted && ( c.Status == CourseStatus.Submitted))
                .OrderByDescending(c => c.CreatedAt)
                .Select(c => new DashboardCourseRowVm(
                    c.Id,
                    c.Title,
                    _context.Users.Where(u => u.Id == c.CreatedBy).Select(u => u.FullName ?? u.Username).FirstOrDefault() ?? "Unknown",
                    c.CreatedAt,
                    c.PublishAt,
                    c.Status
                ))
                .ToListAsync();
        }

        public async Task<List<DashboardCourseRowVm>> GetPublishedUnpublishedCoursesAsync()
        {
            return await _context.Courses
                .Where(c => !c.IsDeleted && (c.Status == CourseStatus.Publish || c.Status == CourseStatus.Unpublish || c.Status == CourseStatus.Approved))
                .OrderByDescending(c => c.PublishAt)
                .Select(c => new DashboardCourseRowVm(
                    c.Id,
                    c.Title,
                     _context.Users.Where(u => u.Id == c.CreatedBy).Select(u => u.FullName ?? u.Username).FirstOrDefault() ?? "Unknown",
                    c.CreatedAt,
                    c.PublishAt,
                    c.Status
                ))
                .ToListAsync();
        }

        public async Task<bool> ApproveCourseAsync(Guid courseId)
        {
            var course = await _context.Courses.FindAsync(courseId);
            if (course == null || course.IsDeleted)
            {
                return false;
            }

            course.Status = CourseStatus.Approved;
            course.UpdatedAt = DateTime.UtcNow;

            return true;

        }

        public async Task<bool> RejectCourseAsync(Guid courseId, Guid managerId, string rejectReason)
        {
            var course = await _context.Courses.FindAsync(courseId);
            if (course == null || course.IsDeleted)
            {
                return false;
            }

            course.Status = CourseStatus.Rejected;
            course.UpdatedAt = DateTime.UtcNow;

            var courseManager = await _context.CourseManagers.FirstOrDefaultAsync(c => c.CourseId == courseId && c.UserId == managerId);

            if (courseManager == null)
            {
                courseManager = new CourseManager
                {
                    CourseId = course.Id,
                    UserId = managerId,
                    RejectReason = rejectReason
                };
                _context.CourseManagers.Add(courseManager);
            }
            else
            {
                courseManager.RejectReason = rejectReason;
            }

            return true;
        }

        public async Task<bool> UnpublishCourseAsync(Guid courseId)
        {
            var course = await _context.Courses.FindAsync(courseId);
            if (course == null || course.IsDeleted) return false;

            course.Status = CourseStatus.Unpublish;
            course.PublishAt = null; 
            course.UpdatedAt = DateTime.UtcNow;

            return true; 
        }
        public async Task<bool> PublishCourseAsync(Guid courseId, DateTime publishDate, decimal price)
        {
            var course = await _context.Courses.FindAsync(courseId);
            if (course == null || course.IsDeleted) return false;
            
            course.Status = CourseStatus.Publish;
            course.PublishAt = publishDate;
            course.UpdatedAt = DateTime.UtcNow;
        
            var existingPrice = await _context.CoursePrices
                .FirstOrDefaultAsync(p => p.CourseId == courseId && p.IsActive);
            
            if (existingPrice != null)
            {
                existingPrice.IsActive = false; 
                existingPrice.EndDate = DateTime.UtcNow;
            }

            var newPrice = new Domain.Entities.CoursePrice
            {
                CourseId = courseId,
                PriceAmount = price,
                EffectiveDate = publishDate,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            _context.CoursePrices.Add(newPrice);
            return true; 
        }

    }
}