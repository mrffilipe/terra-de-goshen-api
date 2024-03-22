using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.src.Presentation;

public class ProductController : BaseController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    [Route("add-product")]
    public async Task<Product> AddProduct([FromBody] Product product)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("get-product-by-id")]
    public async Task<Product> GetProductById([FromQuery] Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    [Route("get-all-products")]
    public async Task<IList<Product>> GetAllProducts()
    {
        throw new NotImplementedException();
    }
}