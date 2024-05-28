namespace TerraDeGoshenAPI.src.Domain
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(Guid id);
        Task<IList<Product>> GetAllProductsAsync();
        Task<Product> UpdateProductAsync(Product product);
    }
}