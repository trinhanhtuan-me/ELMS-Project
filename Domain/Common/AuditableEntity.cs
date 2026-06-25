using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableEntity<TId> : Entity<TId>
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
        public string? LastUpdatedBy { get; set; }
    }
}
