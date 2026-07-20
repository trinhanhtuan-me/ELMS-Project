using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Learning
{
    public sealed record AssignmentLearningDto(
        Guid ItemId,
        Guid AssignmentId,
        string Title,
        string Content,
        string Instructions,
        AssignmentSubmissionType SubmissionType,
        decimal MaxScore,
        decimal PassingScorePct,

        // Work
        string? TextAnswer,
        string? FileUrl,
        AssignmentWorkStatus? Status,
        decimal? Score,
        string? FeedbackText,
        DateTime? DraftSavedAt
    );
}
