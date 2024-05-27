using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Infrastructure
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            string projectId = configuration["Firestore:ProjectId"];
            string jsonCredentials = configuration["Firestore:JsonCredentials"];

            var builder = new FirestoreDbBuilder
            {
                ProjectId = projectId,
                JsonCredentials = jsonCredentials,
                DatabaseId = "mrffilipe-db1"
            };

            services.AddSingleton(builder.Build());
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddSingleton(StorageClient.Create());
            services.AddScoped<IImageRepository>(provider =>
            {
                var storageClient = provider.GetRequiredService<StorageClient>();
                var bucketName = configuration["mrffilipe_bucket"];
                return new ImageRepository(storageClient, bucketName);
            });

            return services;
        }
    }
}