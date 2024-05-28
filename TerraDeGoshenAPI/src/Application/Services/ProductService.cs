using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            try
            {
                return await _productRepository.AddProductAsync(product);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            try
            {
                var product = await _productRepository.GetProductByIdAsync(id);

                if (product != null)
                {
                    return product;
                }
                else
                {
                    // ...
                    throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _productRepository.GetAllProductsAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            try
            {
                return await _productRepository.UpdateProductAsync(product);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}