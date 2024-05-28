namespace TerraDeGoshenAPI.src.Domain
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProductById(Guid id);
        Task<IList<Product>> GetAllProducts();
        Task<Product> UpdateProductName(Guid id, string name);
        Task<Product> UpdateProductDescription(Guid id, string description);
        Task<Product> UpdateProductPrice(Guid id, decimal value);
        Task<Product> UpdateProductColors(Guid id, ColorRef colors);
        Task<Product> UpdateProductSizes(Guid id, SizeRef sizes);
        Task<Product> UpdateProductCategory(Guid id, CategoryRef category);
        Task<Product> UpdateProductQuantity(Guid id, int value);
    }
}