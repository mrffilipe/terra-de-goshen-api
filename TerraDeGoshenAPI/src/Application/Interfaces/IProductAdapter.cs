namespace TerraDeGoshenAPI.src.Application
{
    public interface IProductAdapter
    {
        Task<ProductResponseDTO> AddProduct(ProductCreateDTO product);
        Task<ProductResponseDTO> GetProductById(Guid id);
        Task<IList<MinimumProductResponseDTO>> GetAllProducts();
        Task<ProductResponseDTO> UpdateProduct(ProductUpdateDTO product);
    }
}