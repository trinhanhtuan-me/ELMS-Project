using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Exceptions;
using Application.Interfaces;
using Application.Utils;
using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerProfileService
    {
        Task<bool> ChangePasswordAsync(Guid userId, ChangePasswordRequest request);
        Task<ManagerProfileVm> GetProfileAsync(Guid userId);
        Task<bool> UpdateProfileAsync(ManagerProfileVm request);
    }

    public class ManagerProfileService : IManagerProfileService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUnitOfWork _uow;
        private readonly IManagerProfileRepository _profileRepo;
        private readonly IFileStorageService _fileStorageService;

        public ManagerProfileService(IUserRepository userRepo, IUnitOfWork uow,
                                     IManagerProfileRepository profileRepo, IFileStorageService fileStorageService)
        {
            _userRepo = userRepo;
            _uow = uow;
            _profileRepo = profileRepo;
            _fileStorageService = fileStorageService;

        }

        public async Task<bool> ChangePasswordAsync(Guid userId, ChangePasswordRequest request)
        {
            var user = await _userRepo.FindByIdAsync(userId);
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
        public async Task<ManagerProfileVm> GetProfileAsync(Guid userId)
        {
            var user = await _profileRepo.GetManagerWithProfileAsync(userId);
            if (user == null) throw new BusinessRuleException("User not found!");
            return new ManagerProfileVm
            {
                UserId = user.Id,
                FullName = user.FullName ?? "",
                Email = user.Email ?? "",
                DateOfBirth = user.DateOfBirth,
                AvatarUrl = user.Avatar,
                Position = user.ManagerProfile?.Position,
                Specialization = user.ManagerProfile?.Specialization
            };
        }
        public async Task<bool> UpdateProfileAsync(ManagerProfileVm request)
        {
            var user = await _profileRepo.GetManagerWithProfileAsync(request.UserId);
            if (user == null) throw new BusinessRuleException("User not found!");

            user.FullName = request.FullName;
            user.Email = request.Email;
            user.DateOfBirth = request.DateOfBirth;

            if (request.AvatarFile != null)
            {
             
                var url = await _fileStorageService.SaveFileAsync(request.AvatarFile, "elms-avatars");

                if (!string.IsNullOrEmpty(url))
                {
                    user.Avatar = url;
                }
            }

            var profile = user.ManagerProfile ?? new ManagerProfile { Id = user.Id };
            profile.Position = request.Position;
            profile.Specialization = request.Specialization;

            await _profileRepo.UpdateManagerProfileAsync(user, profile);
            await _uow.SaveChangeAsync();
            return true;
        }

    }
}
