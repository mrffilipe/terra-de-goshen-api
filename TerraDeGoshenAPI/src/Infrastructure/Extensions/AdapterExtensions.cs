using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public static class AdapterExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            services.AddScoped<ICashRegisterAdapter, CashRegisterAdapter>();
            services.AddScoped<ICustomerAdapter, CustomerAdapter>();
            services.AddScoped<IDebtAdapter, DebtAdapter>();
            services.AddScoped<IProductAdapter, ProductAdapter>();
            services.AddScoped<ITransactionAdapter, TransactionAdapter>();

            return services;
        }
    }
}