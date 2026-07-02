using Application.Dtos.Manager;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerDashboardService
    {
        Task<DashboardVm> GetDashboardAsync();
    }
    public class ManagerDashboardService(IManagerDashboardRepository _repo) : IManagerDashboardService
    {
        public async Task<DashboardVm> GetDashboardAsync()
        {
            var currentYear = DateTime.Now.Year;
            var totalCourses = await _repo.GetTotalCoursesAsync();
            var totalInstructors = await _repo.GetTotalInstructorsAsync();
            var pendingCourses = await _repo.GetPendingCoursesAsync();
            var totalRevenue30d = await _repo.GetTotalRevenue30dAsync();
            var monthlyRevenue = await _repo.GetMonthlyRevenueAsync(currentYear);
            var statusCounts = await _repo.GetCourseStatusCountsAsync();
            var approvedRejected = await _repo.GetApprovedRejectedCoursesAsync();
            var publishedUnpub = await _repo.GetPublishedUnpublishedCoursesAsync();
            return new DashboardVm(
                TotalCourses: totalCourses,
                TotalRevenue30d: totalRevenue30d,
                TotalInstructors: totalInstructors,
                PendingCourses: pendingCourses,
                MonthlyRevenue: monthlyRevenue,
                CourseStatusCounts: statusCounts,
                ApprovedRejected: approvedRejected,
                PublishedUnpublished: publishedUnpub
            );
        }
    }
}
