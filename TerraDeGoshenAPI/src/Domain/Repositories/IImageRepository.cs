namespace TerraDeGoshenAPI.src.Domain
{
    public interface IImageRepository
    {
        Task<string> UploadImageAsync(IFormFile file);
        Task DeleteImage(string imageUrl);
    }
}