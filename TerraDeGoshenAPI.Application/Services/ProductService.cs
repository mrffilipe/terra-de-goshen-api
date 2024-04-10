using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> AddProduct(Product product)
    {
        try
        {
            return await _productRepository.AddProduct(product);
        }
        catch (Exception ex)
        {
            throw new NotImplementedException();
        }
    }

    public async Task<Product> GetProductById(Guid id)
    {
        try
        {
            var product = await _productRepository.GetProductById(id);

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

    public async Task<IList<Product>> GetAllProducts()
    {
        try
        {
            return await _productRepository.GetAllProducts();
        }
        catch (Exception ex)
        {
            throw new NotImplementedException();
        }
    }

    public async Task<Product> UpdateProductName(Guid id, string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductDescription(Guid id, string description)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductPrice(Guid id, decimal value)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductColors(Guid id, ColorRef colors)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductSizes(Guid id, SizeRef sizes)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductCategory(Guid id, CategoryRef category)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateProductQuantity(Guid id, int value)
    {
        throw new NotImplementedException();
    }
}