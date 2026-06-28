using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mail : AuditableEntity<Guid>
    {
        public Mail()
        {
            Id = Guid.NewGuid();
        }

        public string To { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public MailStatus Status { get; set; } = MailStatus.Pending;
        public DateTime? SentAt { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
