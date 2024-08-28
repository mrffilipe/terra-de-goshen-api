using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<ImageVO> UploadImageAsync(IFormFile file, bool? isCover = false)
        {
            var imageUrl = await _imageRepository.UploadImageAsync(file);

            var image = new ImageVO(imageUrl, isCover);

            return image;
        }

        public async Task DeleteImageAsync(string imageUrl)
        {
            throw new NotImplementedException();
        }
    }
}