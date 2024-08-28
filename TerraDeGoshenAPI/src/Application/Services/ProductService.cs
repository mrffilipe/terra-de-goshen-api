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
            return await _productRepository.AddProductAsync(product);
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
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

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<IList<Product>> GetProductsByParametersAsync(SearchParameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            return await _productRepository.UpdateProductAsync(product);
        }

        public async Task<IList<CategoryRef>> GetAllCategoriesAsync()
        {
            return await _productRepository.GetAllCategoriesAsync();
        }

        public async Task<IList<ColorRef>> GetAllColorsAsync()
        {
            return await _productRepository.GetAllColorsAsync();
        }

        public async Task<IList<SizeRef>> GetAllSizesAsync()
        {
            return await _productRepository.GetAllSizesAsync();
        }
    }
}