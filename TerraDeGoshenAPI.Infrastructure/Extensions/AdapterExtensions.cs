﻿using Microsoft.Extensions.DependencyInjection;

namespace TerraDeGoshenAPI.Infrastructure
{
    public static class AdapterExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            //services.AddScoped<IProductAdapter, ProductAdapter>();

            return services;
        }
    }
}