using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
            
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception(ex.Message);
            }
        }
    }
}