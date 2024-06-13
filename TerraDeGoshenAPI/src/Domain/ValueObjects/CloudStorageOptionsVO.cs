namespace TerraDeGoshenAPI.src.Domain
{
    public record CloudStorageOptionsVO
    {
        public string BucketName { get; } = string.Empty;

        public CloudStorageOptionsVO()
        { }

        public CloudStorageOptionsVO(string bucketName)
        {
            BucketName = bucketName;
        }
    }
}