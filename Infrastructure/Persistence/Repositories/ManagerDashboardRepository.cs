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

        public async Task<CourseDetailVm?> GetCourseDetailAsync(Guid courseId)
        {
            var courseDetail = await _context.Courses
                .AsNoTracking() 
                .Where(c => c.Id == courseId && !c.IsDeleted)
                .Select(c => new CourseDetailVm
                {
                    CourseId = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    CreatedAt = c.CreatedAt,
                    Status = c.Status.ToString().ToLower(),

                    Price = c.CoursePrice != null && c.CoursePrice.IsActive ? c.CoursePrice.PriceAmount : null,

                    // thông tin Giảng viên 
                    Instructor = new InstructorDetailVm
                    {
                        FullName = c.CreatedByNavigation.IdNavigation.FullName ?? "Chưa cập nhật",
                        Email = c.CreatedByNavigation.IdNavigation.Email,
                        Expertise = c.CreatedByNavigation.Expertise,
                        Bio = c.CreatedByNavigation.Bio
                    },

                    // count
                    Stats = new CourseStatsVm
                    {
                        ModuleCount = c.Modules.Count(),
                        LessonCount = c.Modules.SelectMany(m => m.ModuleItems).Count(i => i.ItemType == ModuleItemType.Lesson),
                        QuizCount = c.Modules.SelectMany(m => m.ModuleItems).Count(i => i.ItemType == ModuleItemType.Quiz),
                        AssignmentCount = c.Modules.SelectMany(m => m.ModuleItems).Count(i => i.ItemType == ModuleItemType.Assignment),
                        DiscussionCount = c.Modules.SelectMany(m => m.ModuleItems).Count(i => i.ItemType == ModuleItemType.Discussion)
                    },

                    // Giáo trình (Modules -> Items -> Lessons/Quizzes -> Questions -> Options)
                    Modules = c.Modules.OrderBy(m => m.OrderIndex).Select(m => new ModuleDetailVm
                    {
                        ModuleId = m.Id,
                        OrderIndex = m.OrderIndex,
                        Title = m.Title,
                        Items = m.ModuleItems.OrderBy(i => i.OrderIndex).Select(i => new ModuleItemDetailVm
                        {
                            ItemId = i.Id,
                            ModuleId = m.Id,
                            ItemType = i.ItemType.ToString().ToLower(), // Ép thành "lesson", "quiz",... cho giống JSP cũ

                            // title
                            Title = i.ItemType == ModuleItemType.Lesson ? i.Lesson!.Title :
                                    i.ItemType == ModuleItemType.Quiz ? i.Quiz!.Title :
                                    i.ItemType == ModuleItemType.Assignment ? i.Assignment!.Title :
                                    i.Discussion!.Title,

                            // lession
                            ContentType = i.Lesson != null ? i.Lesson.ContentType.ToString() : null,
                            VideoUrl = i.Lesson != null ? i.Lesson.VideoUrl : null,
                            DurationSec = i.Lesson != null ? i.Lesson.DurationSec : null,
                            TextContent = i.Lesson != null ? i.Lesson.TextContent : null,

                            // quiz
                            TimeLimitMin = i.Quiz != null ? i.Quiz.TimeLimitMin : null,
                            QuizPassingPct = i.Quiz != null ? i.Quiz.PassingScorePct : null,
                            PickCount = i.Quiz != null ? i.Quiz.PickCount : null,

                            // assignment 
                            SubmissionType = i.Assignment != null ? i.Assignment.SubmissionType.ToString() : null,
                            AssignmentPassingPct = i.Assignment != null ? i.Assignment.PassingScorePct : null,
                            AssignmentInstructions = i.Assignment != null ? i.Assignment.Instructions : null,
                            AttachmentUrl = i.Assignment != null ? i.Assignment.AttachmentUrl : null,
                            AssignmentContent = i.Assignment != null ? i.Assignment.Content : null,

                            // discussion 
                            DiscussionDescription = i.Discussion != null ? i.Discussion.Description : null,

                            // key
                            Questions = i.Lesson != null ? i.Lesson.LessonQuestions.Select(lq => new QuestionDetailVm
                            {
                                QuestionId = lq.Id,
                                Content = lq.Content,
                                Explanation = lq.Explanation,
                                Options = lq.LessonOptions.Select(lo => new QuestionOptionVm
                                {
                                    Content = lo.Content,
                                    IsCorrect = lo.IsCorrect
                                }).ToList()
                            }).ToList() :
                            i.Quiz != null ? i.Quiz.QuizQuestions.Where(qq => !qq.IsDeleted).Select(qq => new QuestionDetailVm
                            {
                                QuestionId = qq.Id,
                                Content = qq.Content,
                                MediaUrl = qq.MediaUrl,
                                Explanation = qq.Explanation,
                                Options = qq.QuizOptions.Select(qo => new QuestionOptionVm
                                {
                                    Content = qo.Content,
                                    IsCorrect = qo.IsCorrect
                                }).ToList()
                            }).ToList() : new List<QuestionDetailVm>()

                        }).ToList()
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            return courseDetail;
        }


    }
}