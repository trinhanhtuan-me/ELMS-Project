using Application.Common.Interfaces;
using Application.Dtos.ParentProfile;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IParentProfileService
    {
        Task<ParentProfileVm> GetProfileAsync(Guid userId);
        Task<bool> UpdateProfileAsync(ParentProfileVm request);
    }

    public class ParentProfileService : IParentProfileService
    {
        private readonly IParentRepository _parentRepo;
        private readonly IUnitOfWork _uow;

        public ParentProfileService(
            IParentRepository parentRepo, 
            IUnitOfWork uow)
        {
            _parentRepo = parentRepo;
            _uow = uow;
        }

        public async Task<ParentProfileVm> GetProfileAsync(Guid userId)
        {
            var user = await _parentRepo.GetParentWithProfileAsync(userId);
            if (user == null) throw new BusinessRuleException("User not found!");
            
            return new ParentProfileVm
            {
                UserId = user.Id,
                Username = user.Username ?? "",
                Email = user.Email ?? "",
                FullName = user.FullName,
                DateOfBirth = user.DateOfBirth,
                Phone = user.Phone,
                Gender = user.Gender,
                Address = user.ParentProfile?.Address,
                Occupation = user.ParentProfile?.Occupation,
                AvatarUrl = user.Avatar
            };
        }

        public async Task<bool> UpdateProfileAsync(ParentProfileVm request)
        {
            var user = await _parentRepo.GetParentWithProfileAsync(request.UserId);
            if (user == null) throw new BusinessRuleException("User not found!");

            user.FullName = request.FullName;
            user.DateOfBirth = request.DateOfBirth;
            user.Phone = request.Phone;
            user.Gender = request.Gender;

            var profile = user.ParentProfile ?? new ParentProfile { Id = user.Id };
            profile.Address = request.Address;
            profile.Occupation = request.Occupation;

            await _parentRepo.UpdateParentProfileAsync(user, profile);
            await _uow.SaveChangeAsync();
            return true;
        }
    }
}
