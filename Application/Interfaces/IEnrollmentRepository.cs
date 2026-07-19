using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IEnrollmentRepository
{
    Task<bool> IsEnrolledAsync(Guid courseId, Guid studentId);
    Task AddAsync(Enrollment enrollment);
}
