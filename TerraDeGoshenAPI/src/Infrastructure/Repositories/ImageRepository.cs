using Google.Cloud.Storage.V1;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ImageRepository : IImageRepository
    {
        private readonly StorageClient _storageClient;
        private readonly string _bucketName;

        public ImageRepository(StorageClient storageClient, CloudStorageOptionsVO storageOptions)
        {
            _storageClient = storageClient ?? throw new ArgumentNullException(nameof(storageClient), "O cliente de armazenamento não pode ser nulo.");
            _bucketName = storageOptions.BucketName ?? throw new ArgumentNullException(nameof(storageOptions.BucketName), "O nome do bucket de armazenamento não pode ser nulo.");
        }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("O arquivo de imagem é inválido.", nameof(file));
            }

            var objectName = Path.GetRandomFileName();
            var contentType = file.ContentType;

            using (var stream = file.OpenReadStream())
            {
                var uploadObjectOptions = new UploadObjectOptions
                {
                    PredefinedAcl = PredefinedObjectAcl.PublicRead
                };

                await _storageClient.UploadObjectAsync(_bucketName, objectName, contentType, stream);
            }

            return $"https://storage.googleapis.com/{_bucketName}/{objectName}";
        }

        public async Task DeleteImageAsync(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                throw new ArgumentException("A URL da imagem não pode ser nula ou vazia.", nameof(imageUrl));
            }

            // Implementação futura
            throw new NotImplementedException("A função de exclusão de imagens ainda não foi implementada.");
        }
    }
}