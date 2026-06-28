using Application.Interfaces;
using Domain.Entities;
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
    public class OtpRepository(ElmsDbContext _context) : IOtpRepository
    {
        public async Task AddAsync(Otp otp)
        {
            await _context.Otps.AddAsync(otp);
        }

        public async Task<Otp?> FindAsync(string email, OtpType type)
        {
            return await _context.Otps.FindAsync(email, type);
        }

    }
}
