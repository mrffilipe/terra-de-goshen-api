using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Http;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Infrastructure
{
    public class ImageRepository : IImageRepository
    {
        private readonly StorageClient _storageClient;
        private readonly string _bucketName;

        public ImageRepository(StorageClient storageClient, string bucketName)
        {
            _storageClient = storageClient;
            _bucketName = "mrffilipe_bucket";
        }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            try
            {
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
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
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