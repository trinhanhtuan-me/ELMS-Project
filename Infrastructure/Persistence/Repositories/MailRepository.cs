using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    public class MailRepository(ElmsDbContext _context) : IMailRepository
    {
        public async Task AddAsync(Mail mail)
        {
            await _context.Mails.AddAsync(mail);
        }

        public async Task<List<Mail>> FindPendingEmailAsync(int batchSize = 50)
        {
            return await _context
                .Mails.Where(m => m.Status == MailStatus.Pending)
                .OrderBy(m => m.CreatedAt)
                .Take(batchSize)
                .ToListAsync();

        }

        public async Task UpdateMailStatusAsync(Mail mail, MailStatus status, string? errorMessage)
        {
            mail.Status = status;
            mail.ErrorMessage = errorMessage;
            if (status == MailStatus.Sent)
            {
                mail.SentAt = DateTime.UtcNow;
            }

            _context.Mails.Update(mail);

            //Background services vòng đời scoped nên không dùng unit of work được phải save changes ở đây
            await _context.SaveChangesAsync();
        }
    }
}
