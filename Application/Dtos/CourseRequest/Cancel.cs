using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.CourseRequest
{
    public sealed record CancelCourseRequest(Guid StudentId, Guid CourseRequestId);
}
