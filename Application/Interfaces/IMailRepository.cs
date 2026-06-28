using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMailRepository
    {
        Task<List<Mail>> FindPendingEmailAsync(int batchSize = 50);
        Task AddAsync(Mail mail);
        Task UpdateMailStatusAsync(Mail mail, MailStatus status, string? errorMessage);
    }
}
