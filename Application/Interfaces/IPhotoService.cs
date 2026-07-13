using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IPhotoService
{
    Task<string?> AddPhotoAsync(IFormFile file, string folderName = "elms-avatars");
}
