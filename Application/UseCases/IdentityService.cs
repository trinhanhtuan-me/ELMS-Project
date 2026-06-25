using Application.Common.Interfaces;
using Application.Dtos.Identity;
using Application.Exceptions;
using Application.Interfaces;
using Application.Utils;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IIdentityService
    {
        Task<bool> RegisterAsync(RegisterRequest request);
        Task<User> LoginAsync(LoginRequest request);

    }

    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _user;
        private readonly IUnitOfWork _uow;
        private readonly IRoleRepository _role;
        public IdentityService(IUserRepository user, IUnitOfWork uow, IRoleRepository role)
        {
            _user = user;
            _uow = uow;
            _role = role;
        }

        public async Task<bool> RegisterAsync(RegisterRequest request)
        {
            var findUsernameResult = await _user.FindUserByEmailOrUsernameAsync(request.Username, request.Email);
            if (findUsernameResult != null) throw new BusinessRuleException("Username or email is existed!");

            string hashPasswod = PasswordHasher.HashPassword(request.Password);

            var newUser = new User
            {
                Username = request.Username,
                Email = request.Email,
                Password = hashPasswod,
                Gender = request.Gender,
                IsActive = false,
                IsDeleted = false,
            };
            string roleName;

            if (request.IsStudent!.Value)
            {
                roleName = "Student";
                newUser.StudentProfile = new StudentProfile();
            }
            else
            {
                roleName = "Parent";
                newUser.ParentProfile = new ParentProfile();
            }
            var role = await _role.FindRoleByName(roleName);
            if (role == null) throw new BusinessRuleException("Account role is invalid!");
            newUser.Roles.Add(role);

            await _user.AddAsync(newUser);
            await _uow.SaveChangeAsync();
            return true;
        }


        public async Task<User> LoginAsync(LoginRequest request)
        {
            var foundUser = await _user.FindUserLoginAsync(request.Identifier);
            if (foundUser == null) throw new BusinessRuleException("The account with this username/email is not found!");

            bool validatePassword = PasswordHasher.VerifyPassword(request.Password, foundUser.Password);
            if (!validatePassword) throw new BusinessRuleException("Password is incorrect");
            if (foundUser.IsDeleted) throw new BusinessRuleException("This account is deleted");
            if (!foundUser.IsActive) throw new BusinessRuleException("This account is not verified");

            return foundUser;

        }
    }
}
