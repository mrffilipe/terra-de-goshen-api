using Google.Cloud.Storage.V1;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IImageRepository>(provider =>
            //{
            //    var storageClient = provider.GetRequiredService<StorageClient>();
            //    var bucketName = configuration["mrffilipe_bucket"];
            //    return new ImageRepository(storageClient, bucketName);
            //});

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();

            return services;
        }
    }
}