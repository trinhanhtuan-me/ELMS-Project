using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CatalogCourse
{
    public class CatalogCourseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Thumbnail { get; set; }
        public string? Description { get; set; }
    }
}
