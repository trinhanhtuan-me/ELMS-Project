using Application.Common.Interfaces;
using Application.Common.Mails;
using Application.Dtos.Identity;
using Application.Dtos.SecurityManagement;
using Application.Exceptions;
using Application.Interfaces;
using Application.Utils;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IIdentityService
    {
        Task RegisterAsync(RegisterRequest request);
        Task<User> LoginAsync(LoginRequest request);
        Task VerifyAccountAsync(VerifyAccountRequest request);
        Task ResendRegisterOtpAsync(string email);
        Task ForgotPasswordAsync(ForgotPasswordRequest request);
        Task VerifyForgotPasswordAsync(VerifyForgotPasswordRequest request);
        Task ResetPassword(ResetPasswordRequest request);
        Task ChangePassword(Guid Id, ChangePasswordRequest request);
    }

    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _user;
        private readonly IUnitOfWork _uow;
        private readonly IRoleRepository _role;
        private readonly IMailRepository _mail;
        private readonly IMailBodyBuilder _mailBodyBuilder;
        private readonly IOtpRepository _otp;
        public IdentityService(IUserRepository user, IUnitOfWork uow,
            IRoleRepository role, IMailRepository mail, IMailBodyBuilder mailBodyBuilder,
            IOtpRepository otp)
        {
            _user = user;
            _uow = uow;
            _role = role;
            _mail = mail;
            _mailBodyBuilder = mailBodyBuilder;
            _otp = otp;
        }

        public async Task RegisterAsync(RegisterRequest request)
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
                newUser.StudentProfile = new StudentProfile { Id = newUser.Id };
            }
            else
            {
                roleName = "Parent";
                newUser.ParentProfile = new ParentProfile { Id = newUser.Id };
            }
            var role = await _role.FindRoleByName(roleName);
            if (role == null) throw new BusinessRuleException("Account role is invalid!");
            newUser.Roles.Add(role);

            await _user.AddAsync(newUser);

            string otpCode = new Random().Next(100000, 999999).ToString();

            var mailBody = await _mailBodyBuilder.BuildOtpRegistrationEmail(request.Username, otpCode);

            var mail = new Mail
            {
                To = request.Email,
                Body = mailBody,
                Subject = "ELMS - Account Verification"
            };

            await _mail.AddAsync(mail);

            var otp = new Otp
            {
                Email = request.Email,
                Code = otpCode,
                ExpiryDate = DateTime.UtcNow.AddMinutes(5),
                Type = OtpType.Register,
                IsDeleted = false
            };
            await _otp.AddAsync(otp);

            await _uow.SaveChangeAsync();
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

        public async Task VerifyAccountAsync(VerifyAccountRequest request)
        {

            var user = await _user.FindUserByEmailOrUsernameAsync(request.Email, request.Email);
            if (user == null) throw new BusinessRuleException("System error: User account not found");

            var findOtp = await _otp.FindAsync(user.Email, OtpType.Register);
            if (findOtp == null) throw new BusinessRuleException("There is no OTP verification for this email");
            if (findOtp.ExpiryDate < DateTime.UtcNow || findOtp.IsDeleted) throw new BusinessRuleException("This OTP code is deleted or expired");
            if (findOtp.Code != request.OtpCode) throw new BusinessRuleException("OTP code is incorrect");

            findOtp.IsDeleted = true;


            user.IsActive = true;
            await _uow.SaveChangeAsync();
        }

        public async Task ResendRegisterOtpAsync(string email)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(email, email);
            if (user == null) throw new BusinessRuleException("System error: User account not found.");
            if (user.IsActive) throw new BusinessRuleException("This account is already verified.");

            string otpCode = new Random().Next(100000, 999999).ToString();

            var existingOtp = await _otp.FindAsync(user.Email, OtpType.Register);
            if (existingOtp != null)
            {
                existingOtp.Code = otpCode;
                existingOtp.ExpiryDate = DateTime.UtcNow.AddMinutes(5);
                existingOtp.IsDeleted = false; // Mở khóa lại nếu lỡ bị xóa
            }
            else
            {
                var newOtp = new Otp
                {
                    Email = user.Email,
                    Code = otpCode,
                    ExpiryDate = DateTime.UtcNow.AddMinutes(5),
                    Type = OtpType.Register,
                    IsDeleted = false
                };
                await _otp.AddAsync(newOtp);
            }

            var mailBody = await _mailBodyBuilder.BuildOtpRegistrationEmail(user.Username, otpCode);
            var mail = new Mail
            {
                To = user.Email,
                Body = mailBody,
                Subject = "ELMS - Account Verification"
            };
            await _mail.AddAsync(mail);

            await _uow.SaveChangeAsync();
        }

        public async Task ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Email, request.Email);
            if (user == null) return;

            string otpCode = new Random().Next(100000, 999999).ToString();
            var existingOtp = await _otp.FindAsync(request.Email, OtpType.ForgotPassword);
            if (existingOtp != null)
            {
                existingOtp.Code = otpCode;
                existingOtp.ExpiryDate = DateTime.UtcNow.AddMinutes(5);
                existingOtp.IsDeleted = false;
            }
            else
            {
                var newOtp = new Otp
                {
                    Email = user.Email,
                    Code = otpCode,
                    ExpiryDate = DateTime.UtcNow.AddMinutes(5),
                    Type = OtpType.ForgotPassword,
                    IsDeleted = false
                };
                await _otp.AddAsync(newOtp);
            }

            var mailBody = await _mailBodyBuilder.BuildOtpForgotPassword(request.Email, otpCode);
            var mail = new Mail
            {
                To = user.Email,
                Subject = "ELMS - ForgotPassword",
                Body = mailBody,
            };
            await _mail.AddAsync(mail);

            await _uow.SaveChangeAsync();
        }
        public async Task VerifyForgotPasswordAsync(VerifyForgotPasswordRequest request)
        {
            var findOtp = await _otp.FindAsync(request.Email, OtpType.ForgotPassword);
            if (findOtp == null) throw new BusinessRuleException("Can not find this OTP");
            if (findOtp.IsDeleted || findOtp.ExpiryDate < DateTime.UtcNow)
                throw new BusinessRuleException("This OTP code is deleted or expired");
            if (findOtp.Code != request.Code) throw new BusinessRuleException("Reset code is incorrect");
        }
        public async Task ResetPassword(ResetPasswordRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Email, request.Email);
            if (user == null) throw new BusinessRuleException("Can not find user with this email");
            var findOtp = await _otp.FindAsync(request.Email, OtpType.ForgotPassword);
            if (findOtp == null) throw new BusinessRuleException("Can not find this OTP");
            if (findOtp.IsDeleted || findOtp.ExpiryDate < DateTime.UtcNow)
                throw new BusinessRuleException("This OTP code is deleted or expired");
            if (findOtp.Code != request.Code) throw new BusinessRuleException("Reset code is incorrect");

            var hashedPassword = PasswordHasher.HashPassword(request.NewPassword);
            user.Password = hashedPassword;
            user.LastUpdatedAt = DateTime.UtcNow;
            user.LastUpdatedBy = user.Id.ToString();

            findOtp.IsDeleted = true;

            await _uow.SaveChangeAsync();
        }

        public async Task ChangePassword(Guid Id, ChangePasswordRequest request)
        {
            var user = await _user.FindByIdAsync(Id);
            if (user == null) throw new BusinessRuleException("Can not find user to change password");

            if (request.NewPassword != request.ConfirmPassword)
                throw new BusinessRuleException("Confirm password does not match");

            var hashPassword = user.Password;
            if (hashPassword == null) throw new BusinessRuleException("Can not change password for this user");
            var verifyPassword = PasswordHasher.VerifyPassword(request.CurrentPassword, hashPassword);
            if (!verifyPassword) throw new BusinessRuleException("Current password is incorrect");

            var newHashPassword = PasswordHasher.HashPassword(request.NewPassword);
            user.Password = newHashPassword;
            user.LastUpdatedAt = DateTime.UtcNow;
            user.LastUpdatedBy = user.Id.ToString();

            await _uow.SaveChangeAsync();
        }
    }
}
