using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFileStorageService
    {
        Task<string?> SaveFileAsync(IFormFile file, string folderName);
        Task<FileUploadResult> SaveFileWithMetadataAsync(IFormFile file, string folderName);
    }

    public class FileUploadResult
    {
        public string? Url { get; set; }
        public double? DurationSec { get; set; }
    }
}
