using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAssignmentRepository
    {
        Task<AssignmentWork?> GetByAssignmentWorkAndStudentAsync(Guid assignmentId, Guid studentId);
        Task AddAsync(AssignmentWork work);
    }
}
