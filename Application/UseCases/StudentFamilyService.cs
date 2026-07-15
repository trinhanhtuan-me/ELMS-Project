using Application.Common.Interfaces;
using Application.Common.Mails;
using Application.Dtos.StudentFamily;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System.Security.Principal;

namespace Application.UseCases
{
    public interface IStudentFamilyService
    {
        Task SendParentLink(Guid studentId, SendParentLinkRequest request);
        Task CancelParentLink(Guid studentId, CancelParentLinkRequest request);
        Task<ParentLinkRequest?> FindParentLinkRequest(Guid studentId);
    }


    public class StudentFamilyService : IStudentFamilyService
    {
        private readonly IUnitOfWork _uow;
        private readonly IStudentProfileRepository _student;
        private readonly IParentLinkRequestRepository _parentLink;
        private readonly IParentRepository _parent;
        private readonly IMailRepository _mail;
        private readonly IMailBodyBuilder _mailBodyBuilder;

        public StudentFamilyService(IUnitOfWork uow, IStudentProfileRepository student, IParentLinkRequestRepository parentLink, IParentRepository parent, IMailRepository mail, IMailBodyBuilder mailBodyBuilder)
        {
            _uow = uow;
            _student = student;
            _parentLink = parentLink;
            _parent = parent;
            _mail = mail;
            _mailBodyBuilder = mailBodyBuilder;
        }

        public async Task SendParentLink(Guid studentId, SendParentLinkRequest request)
        {
            var findStudent = await _student.GetByIdAsync(studentId);
            if (findStudent == null) throw new BusinessRuleException("Can not find this student");
            if (findStudent.ParentId != null) throw new BusinessRuleException("This student has linked parent account already");

            var findParent = await _parent.FindByParentEmail(request.ParentEmail);
            if (findParent == null) throw new BusinessRuleException("Can not find this parent email");

            var parentLink = await _parentLink.FindByStudentAndParent(studentId, findParent.Id);
            if (parentLink != null)
            {
                parentLink.Status = ParentLinkRequestStatus.Pending;
                parentLink.LastUpdatedAt = DateTime.UtcNow;
                parentLink.LastUpdatedBy = studentId.ToString();
            }
            else
            {
                var newParentLink = new ParentLinkRequest
                {
                    StudentId = studentId,
                    ParentId = findParent.Id,
                    Status = ParentLinkRequestStatus.Pending,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = studentId.ToString(),
                };
                await _parentLink.CreateAsync(newParentLink);
            }
            var parentName = findParent.IdNavigation.FullName ?? findParent.IdNavigation.Username;
            var studentName = findStudent.IdNavigation.FullName ?? findStudent.IdNavigation.Username;
            var mailBody = await _mailBodyBuilder.BuildParentLink(parentName, studentName);

            var mail = new Mail
            {
                To = findParent.IdNavigation.Email,
                Body = mailBody,
                Subject = "ELMS - Account Link Request"
            };

            await _mail.AddAsync(mail);
            await _uow.SaveChangeAsync();
        }

        public async Task CancelParentLink(Guid studentId, CancelParentLinkRequest request)
        {
            var findRequest = await _parentLink.GetByIdAsync(request.RequestId);
            if (findRequest == null) throw new BusinessRuleException("Can not find parent link request to cancel");
            if (findRequest.Status != ParentLinkRequestStatus.Pending)
                throw new BusinessRuleException("Only pending requests can be canceled");
            if (findRequest.StudentId != studentId) throw new BusinessRuleException("Student can not cancel this request");

            findRequest.Status = ParentLinkRequestStatus.Canceled;
            findRequest.LastUpdatedAt = DateTime.UtcNow;
            findRequest.LastUpdatedBy = studentId.ToString();

            await _uow.SaveChangeAsync();
        }

        public async Task<ParentLinkRequest?> FindParentLinkRequest(Guid studentId)
        {
            var findStudent = await _student.GetByIdAsync(studentId);
            if (findStudent == null) throw new BusinessRuleException("Can not find student");
            return await _parentLink.FindByStudent(studentId);
        }
    }
}
