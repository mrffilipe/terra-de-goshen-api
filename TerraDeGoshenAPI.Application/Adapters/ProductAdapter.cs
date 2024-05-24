using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class ProductAdapter : IProductAdapter
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductAdapter(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<ProductResponseDTO> AddProduct(ProductCreateDTO product)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<ProductResponseDTO> GetProductById(Guid id)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<IList<MinimumProductResponseDTO>> GetAllProducts()
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }

        public Task<ProductResponseDTO> UpdateProduct(ProductUpdateDTO product)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // erro
            }
        }
    }
}