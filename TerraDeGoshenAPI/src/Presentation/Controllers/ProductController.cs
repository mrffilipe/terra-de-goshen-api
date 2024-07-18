using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class ProductController : BaseController
    {
        private readonly IProductAdapter _productAdapter;

        public ProductController(IProductAdapter productAdapter)
        {
            _productAdapter = productAdapter;
        }

        [HttpPost]
        [Route("add-product")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<ProductResponseDTO>> AddProduct([FromForm] ProductCreateDTO product)
        {
            try
            {
                return Ok(await _productAdapter.AddProductAsync(product));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-product-by-id")]
        public async Task<ActionResult<ProductResponseDTO>> GetProductById([FromQuery] Guid id)
        {
            try
            {
                return Ok(await _productAdapter.GetProductByIdAsync(id));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-all-products")]
        public async Task<ActionResult<MinimumProductResponseDTO>> GetAllProducts()
        {
            try
            {
                return Ok(await _productAdapter.GetAllProductsAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-products-by-parameters")]
        public async Task<ActionResult<MinimumProductResponseDTO>> GetProductsByParameters(SearchParameters parameters)
        {
            try
            {
                return Ok(await _productAdapter.GetProductsByParametersAsync(parameters));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        [Route("update-product")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<ProductResponseDTO>> UpdateProduct([FromForm] ProductUpdateDTO product)
        {
            try
            {
                return Ok(await _productAdapter.UpdateProductAsync(product));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-all-categories")]
        public async Task<ActionResult<IList<CategoryResponseDTO>>> GetAllCategories()
        {
            try
            {
                return Ok(await _productAdapter.GetAllCategoriesAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-all-colors")]
        public async Task<ActionResult<IList<ColorResponseDTO>>> GetAllColors()
        {
            try
            {
                return Ok(await _productAdapter.GetAllColorsAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-all-sizes")]
        public async Task<ActionResult<IList<SizeResponseDTO>>> GetAllSizes()
        {
            try
            {
                return Ok(await _productAdapter.GetAllSizesAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}