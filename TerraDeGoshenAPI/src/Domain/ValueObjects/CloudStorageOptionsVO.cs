namespace TerraDeGoshenAPI.src.Domain
{
    public record CloudStorageOptionsVO
    {
        public string BucketName { get; }

        public CloudStorageOptionsVO(string bucketName)
        {
            BucketName = bucketName ?? throw new ArgumentNullException(nameof(bucketName), "O nome do bucket não pode ser nulo.");
        }
    }
}