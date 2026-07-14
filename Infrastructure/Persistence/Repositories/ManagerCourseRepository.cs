using Application.Dtos.Manager;
using Application.Interfaces;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ManagerCourseRepository : IManagerCourseRepository
    {
        private readonly ElmsDbContext _context;

        public ManagerCourseRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<TabulatorResponse<CourseListVm>> GetFilteredCoursesAsync(string status, string keyword, int categoryId, string sort, int page, int size)
        {
            var query = _context.Courses
                .Include(c => c.Category)
                .Include(c => c.CreatedByNavigation)
                    .ThenInclude(i => i.IdNavigation)
                .Include(c => c.CoursePrice)
         
                .AsQueryable();



            // Logic Lọc theo Trạng thái 
            if (!string.IsNullOrEmpty(status) && status.ToLower() != "all")
            {
                var statusStrings = status.Split(',').Select(s => s.Trim()).ToList();
                var validStatuses = new List<CourseStatus>();

                foreach (var s in statusStrings)
                {
                    if (Enum.TryParse<CourseStatus>(s, true, out var parsedStatus))
                    {
                        validStatuses.Add(parsedStatus);
                    }
                }
                if (validStatuses.Any())
                {
                    query = query.Where(c => validStatuses.Contains(c.Status));
                }
            }

            // Lọc theo Danh mục
            if (categoryId > 0)
            {
                query = query.Where(c => c.CategoryId == categoryId);
            }

            // Lọc theo Từ khóa
            if (!string.IsNullOrEmpty(keyword))
            {
                var lowerKeyword = keyword.ToLower();
                query = query.Where(c =>
                    c.Title.ToLower().Contains(lowerKeyword) ||
                    c.CreatedByNavigation.IdNavigation.FullName.ToLower().Contains(lowerKeyword));
            }

            // Sắp xếp
            if (sort?.ToLower() == "oldest")
            {
                query = query.OrderBy(c => c.CreatedAt);
            }
            else
            {
                query = query.OrderByDescending(c => c.CreatedAt);
            }

            // Tính toán Phân trang
            int totalRecords = await query.CountAsync();
            int lastPage = (int)Math.Ceiling((double)totalRecords / size);

            // Cắt dữ liệu đúng trang
            var courses = await query
                .Skip((page - 1) * size)
                .Take(size)
                .Select(c => new CourseListVm
                {
                    CourseId = c.Id,
                    Title = c.Title,
                    Thumbnail = c.Thumbnail,
                    CategoryName = c.Category.Name,
                    TeacherName = c.CreatedByNavigation.IdNavigation.FullName,
                    TeacherAvatar = c.CreatedByNavigation.IdNavigation.Avatar,
                    TeacherEmail = c.CreatedByNavigation.IdNavigation.Email,
                    CreatedAt = c.CreatedAt,
                    CreatedDate = c.CreatedAt.ToString("dd/MM/yyyy"),
                    CreatedTime = c.CreatedAt.ToString("HH:mm"),
                    PublishDate = c.PublishAt.HasValue ? c.PublishAt.Value.ToString("dd/MM/yyyy") : "Not public yet",
                    PublishTime = c.PublishAt.HasValue ? c.PublishAt.Value.ToString("HH:mm") : "",
                    Status = c.Status.ToString().ToLower(),
                    Price = c.CoursePrice != null && c.CoursePrice.IsActive ? c.CoursePrice.PriceAmount : 0
                })
                .ToListAsync();

            return new TabulatorResponse<CourseListVm>
            {
                last_page = lastPage > 0 ? lastPage : 1,
                data = courses
            };
        }
    }
}
