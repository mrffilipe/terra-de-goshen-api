namespace TerraDeGoshenAPI.Application
{
    public class ProductAdapter : IProductAdapter
    {
        public async Task<ProductResponseDTO> AddProduct(ProductCreateDTO product)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<ProductResponseDTO> GetProductById(Guid id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<IList<MinimumProductResponseDTO>> GetAllProducts()
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<ProductResponseDTO> UpdateProduct(ProductUpdateDTO product)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }
    }
}