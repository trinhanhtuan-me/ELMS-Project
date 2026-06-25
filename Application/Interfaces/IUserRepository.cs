using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> FindUserByEmailOrUsernameAsync(string username, string email);
        Task AddAsync(User user);
        Task<User?> FindUserLoginAsync(string identifier);

    }
}
