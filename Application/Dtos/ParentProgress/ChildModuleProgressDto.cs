using System;
using System.Collections.Generic;

namespace Application.Dtos.ParentProgress;

public class ChildModuleProgressDto
{
    public Guid ModuleId { get; set; }
    public string ModuleTitle { get; set; } = null!;
    public int OrderIndex { get; set; }
    public List<ChildModuleItemProgressDto> Items { get; set; } = new();
}
