using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Manager
{
    public class BulkRejectRequest
    {
        public List<Guid> CourseIds { get; set; } = new List<Guid>();
        public string Reason { get; set; } = string.Empty;
    }
}
