using Application.Interfaces;
using Application.Settings;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Infrastructure.Shared.Storage
{
    public class CloudinaryStorageService : IFileStorageService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryStorageService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);
            _cloudinary.Api.Secure = true; 
        }

        public async Task<string?> SaveFileAsync(IFormFile file, string folderName)
        {
           
            if (file == null || file.Length == 0)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(folderName))
            {
                throw new ArgumentException("Tên thư mục (folderName) không được để trống.", nameof(folderName));
            }

            UploadResult uploadResult;
            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new AutoUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Folder = folderName,
                    UseFilename = true,
                    UniqueFilename = true
                };

                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }
            if (uploadResult.Error != null)
            {
                throw new Exception($"Cloudinary Upload Error: {uploadResult.Error.Message}");
            }

            return uploadResult.SecureUrl?.ToString();
        }

        public async Task<FileUploadResult> SaveFileWithMetadataAsync(IFormFile file, string folderName)
        {
            if (file == null || file.Length == 0)
            {
                return new FileUploadResult();
            }
            if (string.IsNullOrWhiteSpace(folderName))
            {
                throw new ArgumentException("Tên thư mục (folderName) không được để trống.", nameof(folderName));
            }

            VideoUploadResult uploadResult;
            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new VideoUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Folder = folderName,
                    UseFilename = true,
                    UniqueFilename = true
                };

                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }
            if (uploadResult.Error != null)
            {
                throw new Exception($"Cloudinary Upload Error: {uploadResult.Error.Message}");
            }

            return new FileUploadResult
            {
                Url = uploadResult.SecureUrl?.ToString(),
                DurationSec = uploadResult.Duration
            };
        }
    }
}
