namespace TerraDeGoshenAPI.src.Domain
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProductById(Guid id);
        Task<IList<Product>> GetAllProducts();
        Task<Product> UpdateProduct(Product product);
    }
}