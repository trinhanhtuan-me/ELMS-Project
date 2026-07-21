using Application.Common;
using Application.Dtos.CatalogCourse;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ICatalogService
    {
        Task<PaginatedList<CatalogCourseDto>> SearchCatalogAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels, string sortBy, int page, int pageSize);
        Task<(List<string> Languages, List<string> Levels)> GetFilterOptionsAsync();
    }

    public class CatalogService : ICatalogService
    {
        private readonly ICourseRepository _course;
        public CatalogService(ICourseRepository courseRepository)
        {
            _course = courseRepository;
        }

        public async Task<PaginatedList<CatalogCourseDto>> SearchCatalogAsync(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels, string sortBy, int page, int pageSize)
        {
            int totalCount = await _course.CountSearchCoursesAsync(keyword, categoryIds, languages, levels);
            var courses = await _course.SearchCoursesAsync(keyword, categoryIds, languages, levels, sortBy, page, pageSize);
            var courseDtos = courses.Select(c => new CatalogCourseDto
            {
                Id = c.Id,
                Title = c.Title,
                Thumbnail = c.Thumbnail,
                Description = c.Description
            }).ToList();
            return new PaginatedList<CatalogCourseDto>(totalCount, courseDtos);
        }

        public async Task<(List<string> Languages, List<string> Levels)> GetFilterOptionsAsync()
        {
            return await _course.GetFilterOptionsAsync();
        }
    }
}
