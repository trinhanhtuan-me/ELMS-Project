using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<bool> IsEnrolledAsync(Guid courseId, Guid studentId);
        Task AddAsync(Enrollment enrollment);
        Task<List<Enrollment>> GetByStudentIdWithCourseAsync(Guid studentId);
        Task<List<Progress>> GetProgressByStudentAndCourseAsync(Guid studentId, Guid courseId);
        Task<List<Module>> GetModulesWithItemsAndProgressAsync(Guid studentId, Guid courseId);
        Task<bool> IsStudentEnroll(Guid studentId, Guid courseId);
        Task CheckAndUpdateCourseCompletionByModuleItemIdAsync(Guid studentId, Guid moduleItemId);
        Task<List<Enrollment>> GetStudentEnrollmentsWithDetailsAsync(Guid studentId);

    }
}
