using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.MyProgress
{
    public class MyCourseDto
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; } = null!;
        public string? Thumbnail { get; set; }
        public decimal ProgressPercent { get; set; }
        public bool IsCompleted { get; set; }

        public Guid? NextLessonId { get; set; }
        public string? NextLessonTitle { get; set; }
        public int? NextLessonDurationMin { get; set; }
    }
}
