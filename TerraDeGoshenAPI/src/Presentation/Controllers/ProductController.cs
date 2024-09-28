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
        [Route("{id}")]
        public async Task<ActionResult<ProductResponseDTO>> GetProductById(Guid id)
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
        public async Task<ActionResult<IList<ProductResponseDTO>>> GetAllProducts()
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
        [Route("search-by-parameters")]
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
        [Route("category")]
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
        [Route("color")]
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
        [Route("size")]
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