using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class DiscussionReply : AuditableEntity<Guid>
{
    public DiscussionReply() { Id = Guid.NewGuid(); }


    public Guid DiscussionId { get; set; }

    public Guid? ParentReplyId { get; set; }

    public Guid? AuthorId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public virtual User? Author { get; set; }

    public virtual Discussion Discussion { get; set; } = null!;

    public virtual ICollection<DiscussionReply> InverseParentReply { get; set; } = new List<DiscussionReply>();

    public virtual DiscussionReply? ParentReply { get; set; }
}



