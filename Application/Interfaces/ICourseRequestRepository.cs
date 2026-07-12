using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface ICourseRequestRepository
{
    Task<List<CourseRequest>> GetPendingOrUnpaidRequestsAsync(Guid studentId);
    void Update(CourseRequest request);
}
