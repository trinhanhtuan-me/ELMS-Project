using Application.Common;
using Application.Dtos.ParentLink;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IParentLinkService
{
    Task<PaginatedList<ParentLinkRequestResponseDto>> GetRequestsForParentAsync(Guid parentId, string statusFilter, int pageNumber, int pageSize);
    Task<bool> ApproveRequestAsync(Guid parentId, ApproveLinkRequestDto dto);
    Task<bool> RejectRequestAsync(Guid parentId, RejectLinkRequestDto dto);
    Task<bool> UnlinkStudentAsync(Guid parentId, Guid studentId, string? note);
}
