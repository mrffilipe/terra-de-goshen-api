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
            try
            {
                var imageUrl = await _imageRepository.UploadImageAsync(file);

                var image = new ImageVO(imageUrl, isCover);

                return image;
            }
            catch (Exception ex)
            {
                // erro
                throw new NotImplementedException();
            }
        }

        public async Task DeleteImage(string imageUrl)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // erro
                throw new NotImplementedException();
            }
        }
    }
}