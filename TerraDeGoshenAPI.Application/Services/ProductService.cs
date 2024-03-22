using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application;

public class ProductService : IProductService
{
    public async Task<Product> AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetProductById(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IList<Product>> GetAllProducts()
    {
        throw new NotImplementedException();
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