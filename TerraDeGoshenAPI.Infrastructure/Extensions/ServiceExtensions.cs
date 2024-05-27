using Microsoft.Extensions.DependencyInjection;
using TerraDeGoshenAPI.Application;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IImageService, ImageService>();

            return services;
        }
    }
}