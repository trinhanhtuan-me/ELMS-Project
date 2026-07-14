using System;
using System.Collections.Generic;

namespace Application.Dtos.Manager
{
    public class BulkRejectRequest
    {
        public List<Guid> CourseIds { get; set; }
        public string Reason { get; set; }
    }
}
