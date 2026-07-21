using Application.Common.Interfaces;
using Application.Dtos.InstructorProfile;
using Application.Exceptions;
using Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class InstructorProfileService : IInstructorProfileService
    {
        private readonly IInstructorProfileRepository _instructorProfileRepo;
        private readonly IUnitOfWork _uow;

        public InstructorProfileService(IInstructorProfileRepository instructorProfileRepo, IUnitOfWork uow)
        {
            _instructorProfileRepo = instructorProfileRepo;
            _uow = uow;
        }

        public async Task<InstructorProfileVm> GetProfileAsync(Guid userId)
        {
            var profile = await _instructorProfileRepo.GetByIdAsync(userId);
            if (profile == null || profile.IdNavigation == null) throw new BusinessRuleException("Instructor profile not found.");
            
            var user = profile.IdNavigation;
            return new InstructorProfileVm
            {
                UserId = user.Id,
                Username = user.Username ?? "",
                Email = user.Email ?? "",
                FullName = user.FullName,
                DateOfBirth = user.DateOfBirth,
                Phone = user.Phone,
                Gender = user.Gender
            };
        }

        public async Task UpdateProfileAsync(InstructorProfileVm request)
        {
            var profile = await _instructorProfileRepo.GetByIdAsync(request.UserId);
            if (profile == null || profile.IdNavigation == null) throw new BusinessRuleException("Instructor profile not found.");
            
            var user = profile.IdNavigation;

            user.FullName = request.FullName;
            user.DateOfBirth = request.DateOfBirth;
            user.Phone = request.Phone;
            user.Gender = request.Gender;
            user.UpdatedAt = DateTime.UtcNow;

            profile.UpdatedAt = DateTime.UtcNow;
            
            await _instructorProfileRepo.UpdateAsync(profile);
        }
    }
}
