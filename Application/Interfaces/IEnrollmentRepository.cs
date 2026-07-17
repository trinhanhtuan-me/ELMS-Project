using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<bool> IsStudentEnroll(Guid studentId, Guid courseId);
    }
}
