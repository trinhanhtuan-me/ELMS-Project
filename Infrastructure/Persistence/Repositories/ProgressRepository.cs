using Application.Interfaces;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class ProgressRepository(ElmsDbContext _context) : IProgressRepository
    {
        public async Task<bool> UpdateProgressToCompletedAsync(Guid studentId, Guid moduleItemId)
        {
            var progress = await _context.Progresses
                .FirstOrDefaultAsync(p => p.StudentId == studentId && p.ModuleItemId == moduleItemId);
            if (progress != null)
            {
                progress.Status = ProgressStatus.Completed;
                progress.PercentDone = 100;
                return true;
            }
            return false;
        }

        public async Task<bool> IsItemCompletedAsync(Guid studentId, Guid moduleItemId)
        {
            return await _context.Progresses
                .AnyAsync(p => p.StudentId == studentId && p.ModuleItemId == moduleItemId && p.Status == ProgressStatus.Completed);
        }

        public async Task<bool> UpdateQuizProgressAsync(Guid studentId, Guid moduleItemId, decimal scorePct)
        {
            var progress = await _context.Progresses
                .FirstOrDefaultAsync(p => p.StudentId == studentId && p.ModuleItemId == moduleItemId);

            if (progress != null)
            {
                progress.Status = ProgressStatus.Completed;
                progress.PercentDone = 100;

                if (progress.ScorePct == null || scorePct > progress.ScorePct)
                {
                    progress.ScorePct = scorePct;
                }

                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAssignmentProgressAsync(Guid studentId, Guid moduleItemId, decimal scorePct, bool isPassed)
        {
            var progress = await _context.Progresses
                .FirstOrDefaultAsync(p => p.StudentId == studentId && p.ModuleItemId == moduleItemId);

            if (progress != null)
            {
                if (isPassed)
                {
                    progress.Status = ProgressStatus.Completed;
                    progress.PercentDone = 100;
                }

                if (progress.ScorePct == null || scorePct > progress.ScorePct)
                {
                    progress.ScorePct = scorePct;
                }

                return true;
            }
            return false;
        }
    }
}
