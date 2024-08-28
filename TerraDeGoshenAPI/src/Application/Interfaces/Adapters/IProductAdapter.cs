using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> AddProductAsync(ProductCreateDTO product);
        Task<ProductResponseDTO> GetProductByIdAsync(Guid id);
        Task<IList<MinimumProductResponseDTO>> GetAllProductsAsync();
        Task<IList<MinimumProductResponseDTO>> GetProductsByParametersAsync(SearchParameters parameters);
        Task<ProductResponseDTO> UpdateProductAsync(ProductUpdateDTO product);
        Task<IList<CategoryResponseDTO>> GetAllCategoriesAsync();
        Task<IList<ColorResponseDTO>> GetAllColorsAsync();
        Task<IList<SizeResponseDTO>> GetAllSizesAsync();
    }
}