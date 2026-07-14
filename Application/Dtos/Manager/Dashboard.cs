using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Manager
{
    public sealed record MonthlyRevenueVm(int Month, int Year, decimal TotalRevenue);
    public sealed record DashboardCourseRowVm(
        Guid CourseId,
        string Title,
        string InstructorFullName,
        DateTime? CreatedAt,
        DateTime? PublishAt,
        CourseStatus Status
    );

    public sealed record DashboardVm(
        int TotalCourses,
        decimal TotalRevenue30d,
        int TotalInstructors,
        int PendingCourses,
        List<MonthlyRevenueVm> MonthlyRevenue,
        Dictionary<string, int> CourseStatusCounts,
        List<DashboardCourseRowVm> ApprovedRejected,
        List<DashboardCourseRowVm> PublishedUnpublished
    );
}
