using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository), "O repositório de produto não pode ser nulo.");
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

            return await _productRepository.AddProductAsync(product);
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("O ID do produto é inválido.", nameof(id));
            }

            var product = await _productRepository.GetProductByIdAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Produto com ID {id} não encontrado.");
            }

            return product;
        }

        public async Task<IList<Product>> GetProductsByNameAsync(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException("O nome do produto não pode ser nulo ou vazio.", nameof(productName));
            }

            return await _productRepository.GetProductsByNameAsync(productName);
        }

        public async Task<IList<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "O produto não pode ser nulo.");
            }

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