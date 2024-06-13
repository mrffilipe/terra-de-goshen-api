using Google.Cloud.SecretManager.V1;
using Google.Cloud.Storage.V1;
using Newtonsoft.Json;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public static class GoogleCloudConfig
    {
        public static IServiceCollection AddGoogleCloudConfig(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure Secret Manager
            var secretManagerClient = SecretManagerServiceClient.Create();

            string bucketSecretName = "projects/terradegoshen/secrets/terradegoshen_development_bucket_name/versions/latest";
            AccessSecretVersionResponse bucketSecretResponse = secretManagerClient.AccessSecretVersion(bucketSecretName);
            string bucketName = bucketSecretResponse.Payload.Data.ToStringUtf8();

            var cloudStorageBuilder = new StorageClientBuilder().Build();

            services.AddSingleton(cloudStorageBuilder);
            services.AddSingleton(new CloudStorageOptionsVO(bucketName));

            return services;
        }
    }
}