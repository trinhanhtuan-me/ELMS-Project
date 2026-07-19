using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Home
{
    public class HomeCourseVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Thumbnail { get; set; }
        public DateTime? PublishAt { get; set; }
    }
    public class HomeViewModel
    {
        public List<HomeCourseVm> PopularCourses { get; set; } = new List<HomeCourseVm>();
        public List<HomeCourseVm> NewestCourses { get; set; } = new List<HomeCourseVm>();
    }
}
