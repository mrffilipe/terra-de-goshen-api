using Microsoft.AspNetCore.Http;

namespace TerraDeGoshenAPI.Domain;

public interface IImageService
{
    Task<ImageVO> UploadImageAsync(IFormFile file, bool? isCover = false);
    Task DeleteImage(string imageUrl);
}