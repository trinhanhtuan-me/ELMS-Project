using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IParentLinkRequestRepository
{
    Task<ParentLinkRequest?> GetByIdAsync(Guid id);
    Task<ParentLinkRequest?> GetActiveLinkAsync(Guid studentId, Guid parentId);
    Task<List<ParentLinkRequest>> GetRequestsByParentAndStatusAsync(Guid parentId, ParentLinkRequestStatus status, int pageNumber, int pageSize);
    Task<int> CountRequestsByParentAndStatusAsync(Guid parentId, ParentLinkRequestStatus status);
    Task CreateAsync(ParentLinkRequest request);
    Task<ParentLinkRequest?> FindByStudentAndParent(Guid studentId, Guid parentId);
    Task<ParentLinkRequest?> FindByStudent(Guid studentId);

}
