using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    // Nhốt luôn Interface vào đây cho đồng bộ
    public interface IManagerCourseService
    {
        Task<TabulatorResponse<CourseListVm>> GetFilteredCoursesAsync(string status, string keyword, int categoryId, string sort, int page, int size);

        // Cắm sẵn mấy hàm CRUD ở đây để Tí nữa Bước 4 làm Bulk Action (Duyệt hàng loạt)
        // Task<bool> BulkApproveCoursesAsync(Guid[] courseIds);
        // Task<bool> BulkRejectCoursesAsync(Guid[] courseIds, Guid managerId, string reason);
        // Task<bool> UpdatePriceAsync(Guid courseId, decimal newPrice);
    }

    public class ManagerCourseService(IManagerCourseRepository _repo, IUnitOfWork _unitOfWork) : IManagerCourseService
    {
        public async Task<TabulatorResponse<CourseListVm>> GetFilteredCoursesAsync(string status, string keyword, int categoryId, string sort, int page, int size)
        {
            return await _repo.GetFilteredCoursesAsync(status, keyword, categoryId, sort, page, size);
        }

        // Tí nữa các hàm Cập nhật (Approve, Reject, Đổi giá) sẽ dùng _unitOfWork.SaveChangeAsync() ở đây
    }
}
