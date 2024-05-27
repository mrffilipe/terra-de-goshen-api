using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class ProductAdapter : IProductAdapter
    {
        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public ProductAdapter(IProductService productService, IImageService imageService, IMapper mapper)
        {
            _productService = productService;
            _imageService = imageService;
            _mapper = mapper;
        }

        public async Task<ProductResponseDTO> AddProduct(ProductCreateDTO product)
        {
            try
            {
                var mappedProduct = _mapper.Map<Product>(product);

                foreach (var img in product.Images)
                {
                    var imageResult = await _imageService.UploadImageAsync(img.File, img.IsCover);

                    var imageRef = new ImageRef(imageResult);

                    mappedProduct.Images.Add(imageRef);
                }

                mappedProduct = await _productService.AddProduct(mappedProduct);

                return _mapper.Map<ProductResponseDTO>(mappedProduct);
            }
            catch (Exception ex)
            {
                // Logar a exceção real
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw; // Re-throw a exceção original para manter o stack trace
            }
        }

        public async Task<ProductResponseDTO> GetProductById(Guid id)
        {
            try
            {
                var product = await _productService.GetProductById(id);

                if (product == null)
                {
                    throw new Exception();
                }

                return _mapper.Map<ProductResponseDTO>(product);
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception();
            }
        }

        public async Task<IList<MinimumProductResponseDTO>> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProducts();

                if (products == null)
                {
                    throw new Exception();
                }

                return _mapper.Map<IList<MinimumProductResponseDTO>>(products);
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception();
            }
        }

        public async Task<ProductResponseDTO> UpdateProduct(ProductUpdateDTO product)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception();
            }
        }
    }
}