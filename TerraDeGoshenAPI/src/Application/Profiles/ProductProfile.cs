using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductCreateDTO, Product>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ConstructUsing((src, context) => new Product(
                    src.Name,
                    src.Description,
                    src.Price,
                    src.BackgroundText,
                    new List<ImageRef>(),
                    context.Mapper.Map<IList<ColorRef>>(src.Colors),
                    context.Mapper.Map<IList<SizeRef>>(src.Sizes),
                    context.Mapper.Map<CategoryRef>(src.Category),
                    src.QuantityInStock
                    ));

            CreateMap<Product, MinimumProductResponseDTO>()
                .ConstructUsing((src, context) => new MinimumProductResponseDTO(
                    src.Id,
                    src.Name,
                    src.Price,
                    context.Mapper.Map<IList<ImageResponseDTO>>(src.Images),
                    src.CreatedAt,
                    src.UpdatedAt
                    ));

            CreateMap<Product, ProductResponseDTO>()
                .ConstructUsing((src, context) => new ProductResponseDTO(
                    src.Id,
                    src.Name,
                    src.Description,
                    src.Price,
                    src.BackgroundText,
                    context.Mapper.Map<IList<ImageResponseDTO>>(src.Images),
                    context.Mapper.Map<IList<ColorResponseDTO>>(src.Colors),
                    context.Mapper.Map<IList<SizeResponseDTO>>(src.Sizes),
                    context.Mapper.Map<CategoryResponseDTO>(src.Category),
                    src.QuantityInStock,
                    src.CreatedAt,
                    src.UpdatedAt
                    ));
        }
    }
}