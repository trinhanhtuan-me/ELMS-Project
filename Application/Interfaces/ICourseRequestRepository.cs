using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface ICourseRequestRepository
{
    Task<List<CourseRequest>> GetPendingOrUnpaidRequestsAsync(Guid studentId);
    void Update(CourseRequest request);
    Task<List<CourseRequest>> GetPagedRequestsAsync(Guid studentId, string? keyword, CourseRequestStatus? status, string? sortBy, int pageNumber, int pageSize);
    Task<int> CountRequestsAsync(Guid studentId, string? keyword, CourseRequestStatus? status);
    Task CreateAsync(CourseRequest request);
    Task<bool> IsExistCourseRequest(Guid studentId, Guid courseId);
    Task<CourseRequest?> GetCourseRequestById(Guid courseRequestId);
}
