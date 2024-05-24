using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class ProductProfile : Profile
    {
        private readonly IMapper _mapper;

        public ProductProfile(IMapper mapper)
        {
            _mapper = mapper;

            CreateMap<ProductCreateDTO, Product>()
                .ConstructUsing(s => new Product(
                    s.Name,
                    s.Description,
                    s.Price,
                    null,
                    _mapper.Map<IList<ColorRef>>(s.Colors),
                    _mapper.Map<IList<SizeRef>>(s.Sizes),
                    _mapper.Map<CategoryRef>(s.Category),
                    s.QuantityInStock
                    ));

            CreateMap<Product, MinimumProductResponseDTO>()
                .ConstructUsing(s => new MinimumProductResponseDTO(
                    s.Id,
                    s.Name,
                    s.Price,
                    _mapper.Map<IList<ImageResponseDTO>>(s.Images),
                    s.CreatedAt,
                    s.UpdatedAt
                    ));

            CreateMap<Product, ProductResponseDTO>()
                .ConstructUsing(s => new ProductResponseDTO(
                    s.Id,
                    s.Name,
                    s.Description,
                    s.Price,
                    _mapper.Map<IList<ImageResponseDTO>>(s.Images),
                    _mapper.Map<IList<ColorResponseDTO>>(s.Colors),
                    _mapper.Map<IList<SizeResponseDTO>>(s.Sizes),
                    _mapper.Map<CategoryResponseDTO>(s.Category),
                    s.QuantityInStock,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}