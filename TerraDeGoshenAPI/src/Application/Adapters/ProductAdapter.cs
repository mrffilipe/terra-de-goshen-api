using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
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

        public async Task<ProductResponseDTO> AddProductAsync(ProductCreateDTO product)
        {
            var mappedProduct = _mapper.Map<Product>(product);

            var images = new List<ImageRef>();

            foreach (var img in product.Images)
            {
                var imageResult = await _imageService.UploadImageAsync(img.File, img.IsCover);

                var imageRef = new ImageRef(imageResult);

                images.Add(imageRef);
            }

            mappedProduct.SetImages(images);

            mappedProduct = await _productService.AddProductAsync(mappedProduct);

            return _mapper.Map<ProductResponseDTO>(mappedProduct);
        }

        public async Task<ProductResponseDTO> GetProductByIdAsync(Guid id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
            {
                throw new Exception();
            }

            return _mapper.Map<ProductResponseDTO>(product);
        }

        public async Task<IList<ProductResponseDTO>> GetProductsByNameAsync(string productName)
        {
            var result = await _productService.GetProductsByNameAsync(productName);

            return _mapper.Map<IList<ProductResponseDTO>>(result);
        }

        public async Task<IList<ProductResponseDTO>> GetAllProductsAsync()
        {
            var products = await _productService.GetAllProductsAsync();

            if (products == null)
            {
                throw new Exception();
            }

            return _mapper.Map<ProductResponseDTO[]>(products);
        }

        public async Task<ProductResponseDTO> UpdateProductAsync(ProductUpdateDTO product)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CategoryResponseDTO>> GetAllCategoriesAsync()
        {
            var categories = await _productService.GetAllCategoriesAsync();

            return _mapper.Map<IList<CategoryResponseDTO>>(categories);
        }

        public async Task<IList<ColorResponseDTO>> GetAllColorsAsync()
        {
            var colors = await _productService.GetAllColorsAsync();

            return _mapper.Map<IList<ColorResponseDTO>>(colors);
        }

        public async Task<IList<SizeResponseDTO>> GetAllSizesAsync()
        {
            var sizes = await _productService.GetAllSizesAsync();

            return _mapper.Map<IList<SizeResponseDTO>>(sizes);
        }
    }
}