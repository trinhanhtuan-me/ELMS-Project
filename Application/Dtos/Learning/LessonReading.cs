using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Learning
{
    public sealed record ReadingLessonDto(
        Guid ItemId,
        string Title,
        string? TextContent,
        bool IsCompleted
    );

    public sealed record MarkReadingCompletedRequest(
        Guid CourseId,
        Guid ModuleItemId
    );
}
