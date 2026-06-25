using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class LessonQuestion : Entity<Guid>
{
    public LessonQuestion() { Id = Guid.NewGuid(); }


    public Guid LessonId { get; set; }

    public string Content { get; set; } = null!;

    public string? Explanation { get; set; }

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual ICollection<LessonOption> LessonOptions { get; set; } = new List<LessonOption>();
}



