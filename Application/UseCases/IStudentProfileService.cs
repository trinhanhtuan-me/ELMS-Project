using Application.Common.Interfaces;
using Application.Dtos.StudentProfile;
using Application.Exceptions;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IStudentProfileService
    {
        Task<StudentProfileVm> GetProfileAsync(Guid studentId);
        Task<bool> UpdateProfileAsync(StudentProfileVm request);
    }

    public class StudentProfileService : IStudentProfileService
    {
        private readonly IStudentProfileRepository _studentProfileRepo;
        private readonly IUnitOfWork _uow;
        private readonly IFileStorageService _fileStorageService;

        public StudentProfileService(IStudentProfileRepository studentProfileRepo, IUnitOfWork uow, IFileStorageService fileStorageService)
        {
            _studentProfileRepo = studentProfileRepo;
            _uow = uow;
            _fileStorageService = fileStorageService;
        }

        public async Task<StudentProfileVm> GetProfileAsync(Guid studentId)
        {
            var profile = await _studentProfileRepo.GetByIdAsync(studentId);
            if (profile == null || profile.IdNavigation == null) throw new BusinessRuleException("Student profile not found.");
            var user = profile.IdNavigation;
            return new StudentProfileVm
            {
                UserId = user.Id,
                Username = user.Username ?? "",
                Email = user.Email ?? "",
                FullName = user.FullName,
                DateOfBirth = user.DateOfBirth,
                Phone = user.Phone,
                Gender = user.Gender,
                AvatarUrl = user.Avatar,
                GradeLevel = profile.GradeLevel,
                Institution = profile.Institution,
                Address = profile.Address
            };
        }
        public async Task<bool> UpdateProfileAsync(StudentProfileVm request)
        {
            var profile = await _studentProfileRepo.GetByIdAsync(request.UserId);
            if (profile == null || profile.IdNavigation == null) throw new BusinessRuleException("Student profile not found.");
            var user = profile.IdNavigation;

            user.FullName = request.FullName;
            user.DateOfBirth = request.DateOfBirth;
            user.Phone = request.Phone;
            user.Gender = request.Gender;

            if (request.AvatarFile != null)
            {
                var url = await _fileStorageService.SaveFileAsync(request.AvatarFile, "elms-avatars");
                if (!string.IsNullOrEmpty(url))
                {
                    user.Avatar = url;
                }
            }

            profile.GradeLevel = request.GradeLevel;
            profile.Institution = request.Institution;
            profile.Address = request.Address;
            _studentProfileRepo.Update(profile);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}
