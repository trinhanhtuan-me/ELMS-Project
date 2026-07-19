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
    public async Task<CourseRequest?> GetByIdAsync(Guid id)
    {
        return await context.CourseRequests
            .Include(cr => cr.Course)
                .ThenInclude(c => c.CoursePrice)
            .Include(cr => cr.Student)
                .ThenInclude(s => s.IdNavigation)
            .FirstOrDefaultAsync(cr => cr.Id == id);
    }

    public async Task<List<CourseRequest>> GetRequestsByParentAndStatusAsync(Guid parentId, CourseRequestStatus status, int pageNumber, int pageSize)
    {
        return await context.CourseRequests
            .Include(cr => cr.Course)
                .ThenInclude(c => c.CoursePrice)
            .Include(cr => cr.Student)
                .ThenInclude(s => s.IdNavigation)
            .Where(cr => cr.ParentId == parentId && cr.Status == status)
            .OrderByDescending(cr => cr.CreatedAt)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<int> CountRequestsByParentAndStatusAsync(Guid parentId, CourseRequestStatus status)
    {
        return await context.CourseRequests
            .Where(cr => cr.ParentId == parentId && cr.Status == status)
            .CountAsync();
    }

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
