using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Learning
{
    public sealed record VideoLessonDto(
        Guid ItemId,
        string Title,
        string? VideoUrl,
        bool IsCompleted,
        List<LessonQuestionDto> Questions
    );

    public sealed record LessonQuestionDto(
        Guid QuestionId,
        string Content,
        List<LessonOptionDto> Options
    );

    public sealed record LessonOptionDto(
        Guid OptionId,
        string Content,
        bool IsCorrect
    );

    public sealed record SubmitLessonQuestionRequest(
        Guid CourseId,
        Guid ModuleItemId,
        Dictionary<Guid, Guid> Answers
    );
}
