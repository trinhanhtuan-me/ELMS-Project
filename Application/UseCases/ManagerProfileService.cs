using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Exceptions;
using Application.Interfaces;
using Application.Utils;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerProfileService
    {
        Task<bool> ChangePasswordAsync(Guid userId, ChangePasswordRequest request);
    }

    public class ManagerProfileService : IManagerProfileService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUnitOfWork _uow;

        public ManagerProfileService(IUserRepository userRepo, IUnitOfWork uow)
        {
            _userRepo = userRepo;
            _uow = uow;
        }

        public async Task<bool> ChangePasswordAsync(Guid userId, ChangePasswordRequest request)
        {
            var user = await _userRepo.FindUserByIdAsync(userId);
            if (user == null)
                throw new BusinessRuleException("System error: User account not found!");

            // Kiểm tra tài khoản OAuth (Đăng nhập Google)
            if (string.IsNullOrEmpty(user.Password))
            {
                throw new BusinessRuleException("OAuth accounts (Google) cannot change password in this system.");
            }

            // Xác thực mật khẩu cũ bằng BCrypt Hasher
            bool isCorrect = PasswordHasher.VerifyPassword(request.CurrentPassword, user.Password);
            if (!isCorrect)
            {
                throw new BusinessRuleException("Incorrect current password!");
            }

            user.Password = PasswordHasher.HashPassword(request.NewPassword);

            await _uow.SaveChangeAsync();
            return true;
        }
    }
}
