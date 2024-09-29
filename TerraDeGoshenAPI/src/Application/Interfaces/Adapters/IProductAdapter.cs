namespace TerraDeGoshenAPI.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> AddProductAsync(ProductCreateDTO product);
        Task<ProductResponseDTO> GetProductByIdAsync(Guid id);
        Task<IList<ProductResponseDTO>> GetAllProductsAsync();
        Task<IList<ProductResponseDTO>> GetProductsByNameAsync(string productName);
        Task<ProductResponseDTO> UpdateProductAsync(ProductUpdateDTO product);
        Task<IList<CategoryResponseDTO>> GetAllCategoriesAsync();
        Task<IList<ColorResponseDTO>> GetAllColorsAsync();
        Task<IList<SizeResponseDTO>> GetAllSizesAsync();
    }
}