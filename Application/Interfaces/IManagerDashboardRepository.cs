using Application.Dtos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IManagerDashboardRepository
    {
        Task<int> GetTotalCoursesAsync();
        Task<int> GetTotalInstructorsAsync();
        Task<int> GetPendingCoursesAsync();
        Task<decimal> GetTotalRevenue30dAsync();
        Task<List<MonthlyRevenueVm>> GetMonthlyRevenueAsync(int year);
        Task<Dictionary<string, int>> GetCourseStatusCountsAsync();
        Task<List<DashboardCourseRowVm>> GetApprovedRejectedCoursesAsync();
        Task<List<DashboardCourseRowVm>> GetPublishedUnpublishedCoursesAsync();
    }
}
