using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
            
        }

        public async Task<Product> AddProduct(Product product)
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

        public async Task<Product> GetProductById(Guid id)
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

        public async Task<IList<Product>> GetAllProducts()
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

        public async Task<Product> UpdateProduct(Product product)
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