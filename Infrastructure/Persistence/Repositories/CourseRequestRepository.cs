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
    public async Task<List<CourseRequest>> GetPagedRequestsAsync(Guid studentId, string? keyword, CourseRequestStatus? status, string? sortBy, int pageNumber, int pageSize)
    {
        var query = context.CourseRequests
            .Include(x => x.Course)
            .Where(x => x.StudentId == studentId);

        if (status.HasValue)
        {
            query = query.Where(x => x.Status == status.Value);
        }
        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(x => x.Course.Title.Contains(keyword));
        }

        query = sortBy switch
        {
            "NameAsc" => query.OrderBy(x => x.Course.Title),
            "NameDesc" => query.OrderByDescending(x => x.Course.Title),
            "DecidedAtDesc" => query.OrderByDescending(x => x.DecidedAt),
            _ => query.OrderByDescending(x => x.CreatedAt)
        };

        var skip = (pageNumber - 1) * pageSize;

        return await query
            .Skip(skip)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<int> CountRequestsAsync(Guid studentId, string? keyword, CourseRequestStatus? status)
    {
        var query = context.CourseRequests.Where(x => x.StudentId == studentId);
        if (status.HasValue)
        {
            query = query.Where(x => x.Status == status.Value);
        }
        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(x => x.Course.Title.Contains(keyword));
        }
        return await query.CountAsync();
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

    public async Task CreateAsync(CourseRequest request)
    {
        await context.CourseRequests.AddAsync(request);
    }

    public async Task<CourseRequest?> GetCourseRequestById(Guid courseRequestId)
    {
        return await context.CourseRequests
             .Include(r => r.Course)
             .Include(r => r.Student)
             .FirstOrDefaultAsync(r => r.Id == courseRequestId);
    }

    public async Task<bool> IsExistCourseRequest(Guid studentId, Guid courseId)
    {
        return await context.CourseRequests.AnyAsync(r =>
            r.StudentId == studentId &&
            r.CourseId == courseId
        );
    }
}
