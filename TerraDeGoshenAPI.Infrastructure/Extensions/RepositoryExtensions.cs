using Google.Cloud.Firestore;
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
                JsonCredentials = jsonCredentials
            };

            services.AddSingleton(builder.Build());
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}