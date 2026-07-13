using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IManagerProfileRepository
{
    Task<User?> GetManagerWithProfileAsync(Guid userId);
    Task UpdateManagerProfileAsync(User user, ManagerProfile profile);
}
