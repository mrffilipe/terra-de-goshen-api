namespace TerraDeGoshenAPI.src.Domain
{
    public interface IImageRepository
    {
        Task<string> UploadImageAsync(IFormFile file);
        Task DeleteImageAsync(string imageUrl);
    }
}