using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class LessonOption : Entity<Guid>
{
    public LessonOption() { Id = Guid.NewGuid(); }


    public Guid QuestionId { get; set; }

    public string Content { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public virtual LessonQuestion Question { get; set; } = null!;
}



