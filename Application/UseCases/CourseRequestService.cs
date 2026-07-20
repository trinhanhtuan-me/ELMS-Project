using Application.Common;
using Application.Common.Interfaces;
using Application.Common.Mails;
using Application.Dtos.CourseRequest;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface ICourseRequestService
    {
        Task<PaginatedList<GetListCourseRequestVm>> GetListCourseByStudent(Guid studentId, GetListCourseRequest request);
        Task SaveCourseRequest(SaveCourseRequest request);
        Task SendCourseRequest(Guid studentId, SendCourseRequestInput request);
        Task CancelCourseRequest(Guid studentId, CancelCourseRequest request);
    }

    public class CourseRequestService : ICourseRequestService
    {
        private readonly IUnitOfWork _uow;
        private readonly ICourseRequestRepository _courseRequest;
        private readonly IStudentProfileRepository _student;
        private readonly IParentRepository _parent;
        private readonly ICourseRepository _course;

        public CourseRequestService(IUnitOfWork uow, ICourseRequestRepository courseRequest, IStudentProfileRepository student, IParentRepository parent, ICourseRepository course)
        {
            _uow = uow;
            _courseRequest = courseRequest;
            _student = student;
            _parent = parent;
            _course = course;
        }

        public async Task<PaginatedList<GetListCourseRequestVm>> GetListCourseByStudent(Guid studentId, GetListCourseRequest request)
        {
            var findStudent = await _student.GetByIdAsync(studentId);
            if (findStudent == null) throw new BusinessRuleException("Student is not found");

            var totalCount = await _courseRequest.CountRequestsAsync(studentId, request.Keyword, request.Status);

            var listCourseRequest = await _courseRequest.GetPagedRequestsAsync(
                studentId,
                request.Keyword,
                request.Status,
                request.SortBy,
                request.PageNumber,
                request.PageSize
            );

            var result = listCourseRequest.Select(c => new GetListCourseRequestVm(c.Id, c.CourseId, c.Course.Title, c.Status, c.Note)).ToList();

            return new PaginatedList<GetListCourseRequestVm>(totalCount, result);
        }

        public async Task SaveCourseRequest(SaveCourseRequest request)
        {
            var student = await _student.GetByIdAsync(request.StudentId);
            if (student == null) throw new BusinessRuleException("Student is not found.");
            var course = await _course.GetByIdAsync(request.CourseId);
            if (course == null) throw new BusinessRuleException("Course is not found.");

            var isExist = await _courseRequest.IsExistCourseRequest(request.StudentId, request.CourseId);
            if (isExist) throw new BusinessRuleException("You already have a saved request for this course.");

            var newRequest = new CourseRequest
            {
                StudentId = request.StudentId,
                CourseId = request.CourseId,
                ParentId = student.ParentId,
                Status = CourseRequestStatus.Saved,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = request.StudentId.ToString()
            };

            await _courseRequest.CreateAsync(newRequest);
            await _uow.SaveChangeAsync();
        }

        public async Task SendCourseRequest(Guid studentId, SendCourseRequestInput request)
        {
            var existingRequest = await _courseRequest.GetCourseRequestById(request.CourseRequestId);
            if (existingRequest == null) throw new BusinessRuleException("Can not find course request to send");
            var student = existingRequest.Student;
            if (student == null) throw new BusinessRuleException("Student is not found.");
            if (existingRequest.StudentId != studentId) throw new BusinessRuleException("You can not send this request");
            if (student.ParentId == null) throw new BusinessRuleException("You must link a parent account before sending this course request.");

            if (existingRequest.Status != CourseRequestStatus.Saved && existingRequest.Status != CourseRequestStatus.Canceled
                && existingRequest.Status != CourseRequestStatus.Rejected)
                throw new BusinessRuleException("Can not request this course at this state");

            existingRequest.ParentId = student.ParentId.Value;
            existingRequest.Status = CourseRequestStatus.Pending;
            existingRequest.LastUpdatedAt = DateTime.UtcNow;
            existingRequest.LastUpdatedBy = studentId.ToString();

            _courseRequest.Update(existingRequest);
            await _uow.SaveChangeAsync();
        }

        public async Task CancelCourseRequest(Guid studentId, CancelCourseRequest request)
        {
            var existingRequest = await _courseRequest.GetCourseRequestById(request.CourseRequestId);
            if (existingRequest == null) throw new BusinessRuleException("Course request not found.");

            if (existingRequest.StudentId != studentId)
                throw new BusinessRuleException("Security Alert: You are not authorized to cancel this request!");

            if (existingRequest.Status != CourseRequestStatus.Pending && existingRequest.Status != CourseRequestStatus.Unpaid)
                throw new BusinessRuleException("You can only cancel pending or unpaid requests.");

            existingRequest.Status = CourseRequestStatus.Canceled;
            existingRequest.LastUpdatedAt = DateTime.UtcNow;
            existingRequest.LastUpdatedBy = studentId.ToString();

            _courseRequest.Update(existingRequest);
            await _uow.SaveChangeAsync();
        }
    }
}
