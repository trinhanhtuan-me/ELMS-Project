using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface ICourseRequestRepository
{
    Task<CourseRequest?> GetByIdAsync(Guid id);
    Task<List<CourseRequest>> GetRequestsByParentAndStatusAsync(Guid parentId, Domain.Enums.CourseRequestStatus status, int pageNumber, int pageSize);
    Task<int> CountRequestsByParentAndStatusAsync(Guid parentId, Domain.Enums.CourseRequestStatus status);
    Task<List<CourseRequest>> GetPendingOrUnpaidRequestsAsync(Guid studentId);
    void Update(CourseRequest request);
}
