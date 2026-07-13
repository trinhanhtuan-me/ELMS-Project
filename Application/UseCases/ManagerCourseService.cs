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
    }

    public class ManagerCourseService(IManagerCourseRepository _repo, IUnitOfWork _unitOfWork) : IManagerCourseService
    {
        public async Task<TabulatorResponse<CourseListVm>> GetFilteredCoursesAsync(string status, string keyword, int categoryId, string sort, int page, int size)
        {
            return await _repo.GetFilteredCoursesAsync(status, keyword, categoryId, sort, page, size);
        }

        
    }
}
