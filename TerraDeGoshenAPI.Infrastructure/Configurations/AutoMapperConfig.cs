using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TerraDeGoshenAPI.Application;

namespace TerraDeGoshenAPI.Infrastructure
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<CategoryProfile>();
                cfg.AddProfile<ColorProfile>();
                cfg.AddProfile<ImageProfile>();
                cfg.AddProfile<ProductProfile>();
                cfg.AddProfile<SizeProfile>();
            },
            Assembly.GetExecutingAssembly(),
            typeof(CategoryProfile).Assembly,
            typeof(ColorProfile).Assembly,
            typeof(ImageProfile).Assembly,
            typeof(ProductProfile).Assembly,
            typeof(SizeProfile).Assembly);

            return services;
        }
    }
}