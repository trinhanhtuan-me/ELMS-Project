using Application.Common;
using Application.Common.Interfaces;
using Application.Dtos.ParentLink;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCases;

public class ParentLinkService : IParentLinkService
{
    private readonly IParentLinkRequestRepository _linkRequestRepository;
    private readonly IStudentProfileRepository _studentRepository;
    private readonly ICourseRequestRepository _courseRequestRepository;
    private readonly IUnitOfWork _uow;

    public ParentLinkService(
        IParentLinkRequestRepository linkRequestRepository,
        IStudentProfileRepository studentRepository,
        ICourseRequestRepository courseRequestRepository,
        IUnitOfWork uow)
    {
        _linkRequestRepository = linkRequestRepository;
        _studentRepository = studentRepository;
        _courseRequestRepository = courseRequestRepository;
        _uow = uow;
    }

    public async Task<PaginatedList<ParentLinkRequestResponseDto>> GetRequestsForParentAsync(Guid parentId, string statusFilter, int pageNumber, int pageSize)
    {
        if (!Enum.TryParse<ParentLinkRequestStatus>(statusFilter, true, out var status))
        {
            status = ParentLinkRequestStatus.Approved;
        }

        var pageNum = pageNumber <= 0 ? 1 : pageNumber;
        var size = pageSize <= 0 ? 10 : pageSize;
        if (size > 100) size = 100;

        var requests = await _linkRequestRepository.GetRequestsByParentAndStatusAsync(parentId, status, pageNum, size);
        var count = await _linkRequestRepository.CountRequestsByParentAndStatusAsync(parentId, status);

        var data = requests.Select(r => new ParentLinkRequestResponseDto
        {
            RequestId = r.Id,
            StudentId = r.StudentId,
            StudentName = r.Student.IdNavigation.FullName ?? r.Student.IdNavigation.Username,
            StudentEmail = r.Student.IdNavigation.Email,
            Status = r.Status,
            Note = r.Note,
            CreatedAt = r.CreatedAt,
            DecidedAt = r.DecidedAt
        }).ToList();

        return new PaginatedList<ParentLinkRequestResponseDto>(count, data);
    }

    public async Task<bool> ApproveRequestAsync(Guid parentId, ApproveLinkRequestDto dto)
    {
        var request = await _linkRequestRepository.GetByIdAsync(dto.RequestId);
        if (request == null || request.ParentId != parentId || request.Status != ParentLinkRequestStatus.Pending)
            throw new BusinessRuleException("Yêu cầu liên kết không tồn tại hoặc đã được xử lý trước đó.");

        await _uow.BeginAsync();
        try
        {
            request.Status = ParentLinkRequestStatus.Approved;
            request.DecidedAt = DateTime.UtcNow;
            request.Note = dto.Note;

            var student = await _studentRepository.GetByIdAsync(request.StudentId);
            if (student == null) throw new BusinessRuleException("Không tìm thấy thông tin học sinh.");
            if (student.ParentId != null) throw new BusinessRuleException("Học sinh này đã liên kết với phụ huynh khác.");

            student.ParentId = parentId;
            _studentRepository.Update(student);

            await _uow.CommitAsync();
            return true;
        }
        catch
        {
            await _uow.RollBackAsync();
            throw;
        }
    }

    public async Task<bool> RejectRequestAsync(Guid parentId, RejectLinkRequestDto dto)
    {
        var request = await _linkRequestRepository.GetByIdAsync(dto.RequestId);
        if (request == null || request.ParentId != parentId || request.Status != ParentLinkRequestStatus.Pending)
            throw new BusinessRuleException("Yêu cầu không hợp lệ hoặc đã xử lý.");

        request.Status = ParentLinkRequestStatus.Rejected;
        request.DecidedAt = DateTime.UtcNow;
        request.Note = dto.Note;

        await _uow.SaveChangeAsync();
        return true;
    }

    public async Task<bool> UnlinkStudentAsync(Guid parentId, Guid studentId, string? note)
    {
        var student = await _studentRepository.GetByIdAsync(studentId);
        if (student == null || student.ParentId != parentId)
            throw new BusinessRuleException("Học sinh này hiện đang không liên kết với bạn.");

        await _uow.BeginAsync();
        try
        {
            student.ParentId = null;
            _studentRepository.Update(student);

            var activeLink = await _linkRequestRepository.GetActiveLinkAsync(studentId, parentId);
            if (activeLink != null)
            {
                activeLink.Status = ParentLinkRequestStatus.Unlink;
                activeLink.DecidedAt = DateTime.UtcNow;
                activeLink.Note = string.IsNullOrEmpty(note) ? "Phụ huynh chủ động gỡ liên kết." : note;
            }

            var pendingCourseReqs = await _courseRequestRepository.GetPendingOrUnpaidRequestsAsync(studentId);
            foreach (var req in pendingCourseReqs)
            {
                req.Status = CourseRequestStatus.Canceled;
                req.DecidedAt = DateTime.UtcNow;
                req.Note = "Yêu cầu tự động bị hủy vì phụ huynh đã hủy liên kết tài khoản.";
                _courseRequestRepository.Update(req);
            }

            await _uow.CommitAsync();
            return true;
        }
        catch
        {
            await _uow.RollBackAsync();
            throw;
        }
    }
}
