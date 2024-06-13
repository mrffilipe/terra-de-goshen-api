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

        public async Task<IList<Product>> GetProductsByParametersAsync(SearchParameters parameters)
        {
            throw new NotImplementedException();
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

        public async Task<IList<CategoryRef>> GetAllCategoriesAsync()
        {
            try
            {
                return await _productRepository.GetAllCategoriesAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IList<ColorRef>> GetAllColorsAsync()
        {
            try
            {
                return await _productRepository.GetAllColorsAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IList<SizeRef>> GetAllSizesAsync()
        {
            try
            {
                return await _productRepository.GetAllSizesAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}