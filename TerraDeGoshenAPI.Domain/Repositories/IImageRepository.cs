using Microsoft.AspNetCore.Http;

namespace TerraDeGoshenAPI.Domain;

public interface IImageRepository
{
    Task<string> UploadImageAsync(IFormFile file);
    Task DeleteImage(string imageUrl);
}