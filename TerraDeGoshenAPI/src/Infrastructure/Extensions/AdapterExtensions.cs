using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public static class AdapterExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            services.AddScoped<IProductAdapter, ProductAdapter>();

            return services;
        }
    }
}