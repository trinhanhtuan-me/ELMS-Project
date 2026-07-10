using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class PasskeyRepository(ElmsDbContext _context) : IPasskeyRepository
    {
        public async Task Create(Fido2Credential credential)
        {
            await _context.Fido2Credentials.AddAsync(credential);
        }

        public async Task<List<Fido2Credential>> GetPasskeysByUserId(Guid userId)
        {
            return await _context.Fido2Credentials
                .Where(f => f.UserId == userId)
                .ToListAsync();
        }

        public async Task<bool> IsPasskeyExist(byte[] credentialId)
        {
            return await _context.Fido2Credentials
                .AnyAsync(f => f.DescriptorId.SequenceEqual(credentialId));
        }
    }
}
