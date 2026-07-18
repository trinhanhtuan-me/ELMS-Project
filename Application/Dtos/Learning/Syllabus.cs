using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Application.Dtos.Learning
{
    public sealed record LearningSyllabusDto(
        Guid CourseId,
        string CourseTitle,
        List<ModuleSyllabusDto> Modules
    );

    public sealed record ModuleSyllabusDto(
        Guid ModuleId,
        string Title,
        int OrderIndex,
        List<ItemSyllabusDto> Items
    );

    public sealed record ItemSyllabusDto(
        Guid ItemId,
        string Title,
        ModuleItemType ItemType,
        int OrderIndex,
        bool IsCompleted
    );
}
