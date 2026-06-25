using Domain.Enums;
using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Lesson : Entity<Guid>
{
    public Lesson() { Id = Guid.NewGuid(); }


    public string Title { get; set; } = null!;

    public LessonContentType ContentType { get; set; }

    public string? VideoUrl { get; set; }

    public int? DurationSec { get; set; }

    public string? TextContent { get; set; }

    public virtual ModuleItem IdNavigation { get; set; } = null!;

    public virtual ICollection<LessonQuestion> LessonQuestions { get; set; } = new List<LessonQuestion>();
}




