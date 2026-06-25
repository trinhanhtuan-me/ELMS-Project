using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Discussion : Entity<Guid>
{
    public Discussion() { Id = Guid.NewGuid(); }


    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<DiscussionReply> DiscussionReplies { get; set; } = new List<DiscussionReply>();

    public virtual ModuleItem IdNavigation { get; set; } = null!;
}



