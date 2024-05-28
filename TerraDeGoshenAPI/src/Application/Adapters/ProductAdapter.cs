﻿using AutoMapper;
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
            try
            {
                var mappedProduct = _mapper.Map<Product>(product);

                foreach (var img in product.Images)
                {
                    var imageResult = await _imageService.UploadImageAsync(img.File, img.IsCover);

                    var imageRef = new ImageRef(imageResult);

                    mappedProduct.Images.Add(imageRef);
                }

                mappedProduct = await _productService.AddProductAsync(mappedProduct);

                return _mapper.Map<ProductResponseDTO>(mappedProduct);
            }
            catch (Exception ex)
            {
                // erro
                throw new Exception();
            }
        }

        public async Task<ProductResponseDTO> GetProductByIdAsync(Guid id)
        {
            try
            {
                var product = await _productService.GetProductByIdAsync(id);

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

        public async Task<IList<MinimumProductResponseDTO>> GetAllProductsAsync()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();

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

        public async Task<ProductResponseDTO> UpdateProductAsync(ProductUpdateDTO product)
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