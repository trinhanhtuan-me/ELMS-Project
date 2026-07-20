using Application.Common;
using Application.Common.Interfaces;
using Application.Dtos.Billing;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases;

public interface ICourseApprovalService
{
    Task<PaginatedList<CourseRequestResponseDto>> GetRequestsForParentAsync(Guid parentId, string statusFilter, int pageNumber, int pageSize);
    Task<bool> ApproveRequestAsync(Guid parentId, ApproveCourseRequestDto dto);
    Task<bool> RejectRequestAsync(Guid parentId, RejectCourseRequestDto dto);
}

public class CourseApprovalService : ICourseApprovalService
{
    private readonly ICourseRequestRepository _courseRequestRepository;
    private readonly IUnitOfWork _uow;

    public CourseApprovalService(ICourseRequestRepository courseRequestRepository, IUnitOfWork uow)
    {
        _courseRequestRepository = courseRequestRepository;
        _uow = uow;
    }

    public async Task<PaginatedList<CourseRequestResponseDto>> GetRequestsForParentAsync(Guid parentId, string statusFilter, int pageNumber, int pageSize)
    {
        if (!Enum.TryParse<CourseRequestStatus>(statusFilter, true, out var status))
        {
            status = CourseRequestStatus.Pending;
        }

        var pageNum = pageNumber <= 0 ? 1 : pageNumber;
        var size = pageSize <= 0 ? 10 : pageSize;
        if (size > 100) size = 100;

        var requests = await _courseRequestRepository.GetRequestsByParentAndStatusAsync(parentId, status, pageNum, size);
        var count = await _courseRequestRepository.CountRequestsByParentAndStatusAsync(parentId, status);

        var data = requests.Select(r => new CourseRequestResponseDto
        {
            RequestId = r.Id,
            StudentId = r.StudentId,
            StudentName = r.Student.IdNavigation.FullName ?? r.Student.IdNavigation.Username,
            StudentEmail = r.Student.IdNavigation.Email,
            CourseId = r.CourseId,
            CourseName = r.Course.Title,
            PriceVnd = r.Course.CoursePrice?.PriceAmount ?? 0,
            Status = r.Status,
            Note = r.Note,
            CreatedAt = r.CreatedAt,
            DecidedAt = r.DecidedAt
        }).ToList();

        return new PaginatedList<CourseRequestResponseDto>(count, data);
    }

    public async Task<bool> ApproveRequestAsync(Guid parentId, ApproveCourseRequestDto dto)
    {
        var request = await _courseRequestRepository.GetByIdAsync(dto.RequestId);
        if (request == null || request.ParentId != parentId || request.Status != CourseRequestStatus.Pending)
            throw new BusinessRuleException("Yêu cầu duyệt không tồn tại hoặc đã được xử lý trước đó.");

        request.Status = CourseRequestStatus.Unpaid;
        request.DecidedAt = DateTime.UtcNow;
        request.Note = dto.Note;

        _courseRequestRepository.Update(request);
        await _uow.SaveChangeAsync();
        return true;
    }

    public async Task<bool> RejectRequestAsync(Guid parentId, RejectCourseRequestDto dto)
    {
        var request = await _courseRequestRepository.GetByIdAsync(dto.RequestId);
        if (request == null || request.ParentId != parentId || request.Status != CourseRequestStatus.Pending)
            throw new BusinessRuleException("Yêu cầu duyệt không tồn tại hoặc đã được xử lý trước đó.");

        request.Status = CourseRequestStatus.Rejected;
        request.DecidedAt = DateTime.UtcNow;
        request.Note = $"[Phụ huynh] Lý do từ chối: {dto.Note}";

        _courseRequestRepository.Update(request);
        await _uow.SaveChangeAsync();
        return true;
    }
}
