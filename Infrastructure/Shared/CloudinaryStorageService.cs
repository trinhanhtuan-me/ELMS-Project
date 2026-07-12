using System;
using System.IO;
using System.Threading.Tasks;
using Application.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Shared
{
    public class CloudinaryStorageService : IFileStorageService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryStorageService(IConfiguration configuration)
        {
            var cloudName = configuration["Cloudinary:CloudName"];
            var apiKey = configuration["Cloudinary:ApiKey"];
            var apiSecret = configuration["Cloudinary:ApiSecret"];
            
            var account = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(account);
            _cloudinary.Api.Secure = true;
        }

        public async Task<string> SaveFileAsync(Stream fileStream, string fileName, string folderName)
        {
            // Sử dụng ResourceType.Auto để tự động nhận dạng file là ảnh hay video
            var uploadParams = new AutoUploadParams()
            {
                File = new FileDescription(fileName, fileStream),
                Folder = folderName,
                UseFilename = true,
                UniqueFilename = true
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            
            if (uploadResult.Error != null)
            {
                throw new Exception($"Cloudinary Upload Error: {uploadResult.Error.Message}");
            }

            return uploadResult.SecureUrl.ToString();
        }
    }
}
