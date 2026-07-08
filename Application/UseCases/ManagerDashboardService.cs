using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Exceptions;
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
        Task<bool> ApproveCourseAsync(Guid courseId);
        Task<bool> RejectCourseAsync(Guid courseId, Guid managerId, string rejectReason);
        Task<bool> UnpublishCourseAsync(Guid courseId);
        Task<bool> PublishCourseAsync(Guid courseId, DateTime publishDate, decimal price);
        Task<CourseDetailVm?> GetCourseDetailAsync(Guid courseId);

    }
    public class ManagerDashboardService(IManagerDashboardRepository _repo , IUnitOfWork _unitOfWork) : IManagerDashboardService
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

        public async Task<bool> ApproveCourseAsync(Guid courseId)
        {
            var success = await _repo.ApproveCourseAsync(courseId);
            if (success)
            { 
                await _unitOfWork.SaveChangeAsync();
            }
            return success;
        }
        public async Task<bool> RejectCourseAsync(Guid courseId, Guid managerId, string rejectReason)
        {
            var success = await _repo.RejectCourseAsync(courseId, managerId, rejectReason);
            if (success)
            {
                await _unitOfWork.SaveChangeAsync();
            }
            return success;
        }

        public async Task<bool> UnpublishCourseAsync(Guid courseId)
        {
            var success = await _repo.UnpublishCourseAsync(courseId);

            if (!success)
                throw new BusinessRuleException("Course not exitsted or was deleted in system!");

            await _unitOfWork.SaveChangeAsync();
            return true;
        }

        public async Task<bool> PublishCourseAsync(Guid courseId, DateTime publishDate, decimal price)
        {
            var success = await _repo.PublishCourseAsync(courseId, publishDate, price);

            if (!success)
                throw new BusinessRuleException("Course not exitsted or was deleted in system!");

            await _unitOfWork.SaveChangeAsync();
            return true;
        }

        public async Task<CourseDetailVm?> GetCourseDetailAsync(Guid courseId)
        {
            var detail = await _repo.GetCourseDetailAsync(courseId);

            if (detail == null)
                throw new BusinessRuleException("Course not exitsted or was deleted in system!");

            return detail;
        }



    }
}
