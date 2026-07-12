using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class CourseRequestRepository(ElmsDbContext context) : ICourseRequestRepository
{
    public async Task<List<CourseRequest>> GetPendingOrUnpaidRequestsAsync(Guid studentId)
    {
        return await context.CourseRequests
            .Where(cr => cr.StudentId == studentId && 
                         (cr.Status == CourseRequestStatus.Pending || cr.Status == CourseRequestStatus.Unpaid))
            .ToListAsync();
    }

    public void Update(CourseRequest request)
    {
        context.CourseRequests.Update(request);
    }
}
