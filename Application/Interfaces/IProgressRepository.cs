using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProgressRepository 
    {
        Task<bool> UpdateProgressToCompletedAsync(Guid studentId, Guid moduleItemId);
        Task<bool> IsItemCompletedAsync(Guid studentId, Guid moduleItemId);
        Task<bool> UpdateQuizProgressAsync(Guid studentId, Guid moduleItemId, decimal scorePct);
        Task<bool> UpdateAssignmentProgressAsync(Guid studentId, Guid moduleItemId, decimal scorePct, bool isPassed);

    }
}
