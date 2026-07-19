using Application.Common.Interfaces;
using Application.Dtos.Home;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IHomeService
    {
        Task<HomeViewModel> GetHomeDataAsync();
    }

    public class HomeService : IHomeService
    {
        private readonly IUnitOfWork _uow;
        private readonly ICourseRepository _course;

        public HomeService(IUnitOfWork uow, ICourseRepository course)
        {
            _uow = uow;
            _course = course;
        }

        public async Task<HomeViewModel> GetHomeDataAsync()
        {
            var popularCourses = await _course.GetPopularCoursesAsync(4);
            var newestCourses = await _course.GetNewestCoursesAsync(4);

            return new HomeViewModel
            {
                PopularCourses = popularCourses.Select(c => new HomeCourseVm
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Thumbnail = c.Thumbnail,
                    PublishAt = c.PublishAt ?? c.CreatedAt
                }).ToList(),

                NewestCourses = newestCourses.Select(c => new HomeCourseVm
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description,
                    Thumbnail = c.Thumbnail,
                    PublishAt = c.PublishAt ?? c.CreatedAt
                }).ToList()
            };
        }
    }
}
