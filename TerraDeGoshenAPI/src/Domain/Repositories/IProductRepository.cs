namespace TerraDeGoshenAPI.src.Domain
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(Guid id);
        Task<IList<Product>> GetAllProductsAsync();
        Task<IList<Product>> GetProductsByParametersAsync(SearchParameters parameters);
        Task<Product> UpdateProductAsync(Product product);
        Task<IList<CategoryRef>> GetAllCategoriesAsync();
        Task<IList<ColorRef>> GetAllColorsAsync();
        Task<IList<SizeRef>> GetAllSizesAsync();
    }
}