using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository ?? throw new ArgumentNullException(nameof(imageRepository), "O repositório de imagem não pode ser nulo.");
        }

        public async Task<ImageVO> UploadImageAsync(IFormFile file, bool? isCover = false)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("O arquivo de imagem é inválido.", nameof(file));
            }

            var imageUrl = await _imageRepository.UploadImageAsync(file);

            return new ImageVO(imageUrl, isCover);
        }

        public async Task DeleteImageAsync(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                throw new ArgumentException("A URL da imagem não pode ser nula ou vazia.", nameof(imageUrl));
            }

            await _imageRepository.DeleteImageAsync(imageUrl);
        }
    }
}