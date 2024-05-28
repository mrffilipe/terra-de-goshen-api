namespace TerraDeGoshenAPI.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> AddProductAsync(ProductCreateDTO product);
        Task<ProductResponseDTO> GetProductByIdAsync(Guid id);
        Task<IList<MinimumProductResponseDTO>> GetAllProductsAsync();
        Task<ProductResponseDTO> UpdateProductAsync(ProductUpdateDTO product);
    }
}