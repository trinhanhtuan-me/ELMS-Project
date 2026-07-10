using Application.Common.Cache;
using Application.Common.Interfaces;
using Application.Dtos.Passkey;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Fido2NetLib;
using Fido2NetLib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IPasskeyService
    {
        Task<CredentialCreateOptions> RequestPasskeyRegistration(PasskeyOptionsRequest request);
        Task CompletePasskeyRegistration(RegisterPasskeyCompleteRequest request);
        Task<AssertionOptions> RequestPasskeyLogin(PasskeyOptionsRequest request);
        Task<User> CompletePasskeyLogin(CompletePasskeyLoginRequest request);
        Task<bool> HasPasskey(string identifier);
    }

    public class PasskeyService : IPasskeyService
    {
        private readonly IUserRepository _user;
        private readonly IUnitOfWork _uow;
        private readonly ICacheService _cacheService;
        private readonly IPasskeyRepository _passkey;
        private readonly IFido2 _fido2;

        public PasskeyService(IUserRepository user, IUnitOfWork uow, ICacheService cacheService, IPasskeyRepository passkey, IFido2 fido2)
        {
            _user = user;
            _uow = uow;
            _cacheService = cacheService;
            _passkey = passkey;
            _fido2 = fido2;
        }

        public async Task<CredentialCreateOptions> RequestPasskeyRegistration(PasskeyOptionsRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Identifier, request.Identifier);
            if (user == null) throw new BusinessRuleException("Can not find this user");

            var fido2user = new Fido2User
            {
                DisplayName = user.FullName ?? user.Username,
                Name = user.Email,
                Id = Encoding.UTF8.GetBytes(user.Id.ToString())
            };

            var passkeys = await _passkey.GetPasskeysByUserId(user.Id);
            var existingPasskeys = passkeys
                .Select(k => new PublicKeyCredentialDescriptor(k.DescriptorId)).ToList();

            var authenticatorSelection = new AuthenticatorSelection
            {
                RequireResidentKey = false,
                UserVerification = UserVerificationRequirement.Required
            };

            var options = _fido2.RequestNewCredential(fido2user, existingPasskeys, authenticatorSelection, AttestationConveyancePreference.None);

            var cacheKey = "fido2.attestation.options." + request.Identifier;
            await _cacheService.SetAsync<string>(cacheKey, options.ToJson(), TimeSpan.FromMinutes(5));

            return options;
        }


        public async Task CompletePasskeyRegistration(RegisterPasskeyCompleteRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Identifier, request.Identifier);
            if (user == null) throw new BusinessRuleException("Can't not found this user to register passkey");

            var cacheKey = "fido2.attestation.options." + request.Identifier;
            var cacheJson = await _cacheService.GetAsync<string>(cacheKey);
            if (string.IsNullOrEmpty(cacheJson))
                throw new BusinessRuleException("Registration session expired or invalid data. Please try again.");

            var cacheOptions = CredentialCreateOptions.FromJson(cacheJson);

            IsCredentialIdUniqueToUserAsyncDelegate callback = async (args, cancellationToken) =>
            {
                bool isExist = await _passkey.IsPasskeyExist(args.CredentialId);
                return !isExist;
            };

            var result = await _fido2.MakeNewCredentialAsync(request.Attesion, cacheOptions, callback);
            if (result.Status != "ok" || result.Result == null)
                throw new BusinessRuleException(result.ErrorMessage ?? "Passkey verification failed");

            var newPasskey = new Fido2Credential
            {
                UserId = user.Id,
                DescriptorId = result.Result.CredentialId,
                PublicKey = result.Result.PublicKey,
                UserHandle = result.Result.User.Id,
                SignatureCounter = result.Result.Counter,
                CredType = result.Result.CredType,
                RegDate = DateTime.UtcNow,
                AaGuid = result.Result.Aaguid
            };

            await _passkey.Create(newPasskey);
            await _uow.SaveChangeAsync();
            await _cacheService.RemoveAsync(cacheKey);
        }

        public async Task<AssertionOptions> RequestPasskeyLogin(PasskeyOptionsRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Identifier, request.Identifier);
            if (user == null) throw new BusinessRuleException("User not found");

            var existingPasskeys = await _passkey.GetPasskeysByUserId(user.Id);
            if (!existingPasskeys.Any()) throw new BusinessRuleException("This account has no registered passkeys in current device");

            var allowedCredentials = existingPasskeys
                .Select(k => new PublicKeyCredentialDescriptor(k.DescriptorId))
                .ToList();

            var options = _fido2.GetAssertionOptions(allowedCredentials, UserVerificationRequirement.Required);

            var cacheKey = "fido2.assertion.options." + request.Identifier;
            await _cacheService.SetAsync<string>(cacheKey, options.ToJson(), TimeSpan.FromMinutes(5));

            return options;
        }

        public async Task<User> CompletePasskeyLogin(CompletePasskeyLoginRequest request)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(request.Identifier, request.Identifier);
            if (user == null) throw new BusinessRuleException("User not found");

            var cacheKey = "fido2.assertion.options." + request.Identifier;
            var cacheJson = await _cacheService.GetAsync<string>(cacheKey);
            if (string.IsNullOrEmpty(cacheJson))
                throw new BusinessRuleException("Login session expired. Please try again.");

            var cachedOptions = AssertionOptions.FromJson(cacheJson);

            var passkeys = await _passkey.GetPasskeysByUserId(user.Id);
            var passkey = passkeys.FirstOrDefault(p =>
                    p.DescriptorId.SequenceEqual(request.Assertion.Id));
            if (passkey == null) throw new BusinessRuleException("Unrecognized passkey.");

            IsUserHandleOwnerOfCredentialIdAsync callback = async (args, CancellationToken) =>
            {
                return args.UserHandle.SequenceEqual(passkey.UserHandle);
            };

            var result = await _fido2.MakeAssertionAsync(
                request.Assertion,
                cachedOptions,
                passkey.PublicKey,
                passkey.SignatureCounter,
                callback
                );

            if (result.Status != "ok")
                throw new BusinessRuleException(result.ErrorMessage ?? "Passkey verification failed");

            passkey.SignatureCounter = result.Counter;
            await _uow.SaveChangeAsync();
            await _cacheService.RemoveAsync(cacheKey);

            return user;
        }

        public async Task<bool> HasPasskey(string identifier)
        {
            var user = await _user.FindUserByEmailOrUsernameAsync(identifier, identifier);
            if (user == null) throw new BusinessRuleException("User not found");

            var passkeys = await _passkey.GetPasskeysByUserId(user.Id);
            return passkeys != null && passkeys.Any();
        }
    }

}
