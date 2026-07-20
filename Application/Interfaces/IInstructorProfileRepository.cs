using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInstructorProfileRepository
    {
        Task<InstructorProfile?> GetByIdAsync(Guid instructorId);
        Task UpdateAsync(InstructorProfile instructorProfile);
    }
}
