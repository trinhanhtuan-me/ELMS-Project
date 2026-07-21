using Application.Dtos.InstructorProfile;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IInstructorProfileService
    {
        Task<InstructorProfileVm> GetProfileAsync(Guid userId);
        Task UpdateProfileAsync(InstructorProfileVm model);
    }
}
