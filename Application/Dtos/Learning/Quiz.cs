using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Learning
{
    public sealed record QuizIntroDto(
        Guid ItemId,
        string Title,
        int? TimeLimitMin,
        decimal PassingScorePct,
        int AttemptCooldownMin,
        bool IsCompleted,
        decimal? BestScorePct,
        bool IsCooldownActive,
        int? RemainingCooldownMin
    );
    public sealed record QuizAttemptDto(
        Guid AttemptId,
        string QuizTitle,
        int? TimeLimitMin,
        DateTime StartedAt,
        List<QuizAttemptQuestionDto> Questions
    );
    public sealed record QuizAttemptQuestionDto(
        Guid QuestionId,
        string Content,
        string? MediaUrl,
        byte DisplayOrder,
        List<QuizOptionDto> Options
    );
    public sealed record QuizOptionDto(
        Guid OptionId,
        string Content
    );
    public sealed record SubmitQuizAttemptRequest(
        Guid AttemptId,
        Dictionary<Guid, Guid> Answers 
    );
}
