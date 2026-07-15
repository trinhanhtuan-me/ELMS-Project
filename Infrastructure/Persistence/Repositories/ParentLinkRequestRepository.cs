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

public class ParentLinkRequestRepository(ElmsDbContext context) : IParentLinkRequestRepository
{
    public async Task<ParentLinkRequest?> GetByIdAsync(Guid id)
    {
        return await context.ParentLinkRequests.FindAsync(id);
    }

    public async Task<ParentLinkRequest?> GetActiveLinkAsync(Guid studentId, Guid parentId)
    {
        return await context.ParentLinkRequests
            .FirstOrDefaultAsync(r => r.StudentId == studentId && r.ParentId == parentId && r.Status == ParentLinkRequestStatus.Approved);
    }

    public async Task<List<ParentLinkRequest>> GetRequestsByParentAndStatusAsync(Guid parentId, ParentLinkRequestStatus status, int pageNumber, int pageSize)
    {
        return await context.ParentLinkRequests
            .Include(r => r.Student)
                .ThenInclude(s => s.IdNavigation)
            .Where(r => r.ParentId == parentId && r.Status == status)
            .OrderByDescending(r => r.CreatedAt)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<int> CountRequestsByParentAndStatusAsync(Guid parentId, ParentLinkRequestStatus status)
    {
        return await context.ParentLinkRequests
            .Where(r => r.ParentId == parentId && r.Status == status)
            .CountAsync();
    }

    public async Task CreateAsync(ParentLinkRequest request)
    {
        await context.ParentLinkRequests.AddAsync(request);
    }

    public async Task<ParentLinkRequest?> FindByStudentAndParent(Guid studentId, Guid parentId)
    {
        return await context.ParentLinkRequests.FirstOrDefaultAsync(l => l.StudentId == studentId && l.ParentId == parentId);
    }

    public async Task<ParentLinkRequest?> FindByStudent(Guid studentId)
    {
        return await context.ParentLinkRequests
         .Include(req => req.Parent)
             .ThenInclude(p => p.IdNavigation)
         .OrderByDescending(req => req.CreatedAt)
         .FirstOrDefaultAsync(req => req.StudentId == studentId);
    }
}
