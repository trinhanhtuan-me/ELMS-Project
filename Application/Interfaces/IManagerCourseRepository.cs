using Application.Dtos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IManagerCourseRepository
    {
        Task<TabulatorResponse<CourseListVm>> GetFilteredCoursesAsync(string status, string keyword, int categoryId, string sort, int page, int size);
    }
}
