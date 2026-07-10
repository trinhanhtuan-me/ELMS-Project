using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPasskeyRepository
    {
        Task<List<Fido2Credential>> GetPasskeysByUserId(Guid userId);
        Task<bool> IsPasskeyExist(byte[] credentialId);
        Task Create(Fido2Credential credential);
    }
}
