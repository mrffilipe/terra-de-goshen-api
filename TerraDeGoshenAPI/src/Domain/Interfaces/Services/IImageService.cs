namespace TerraDeGoshenAPI.src.Domain
{
    public interface IImageService
    {
        Task<ImageVO> UploadImageAsync(IFormFile file, bool? isCover);
        Task DeleteImageAsync(string imageUrl);
    }
}