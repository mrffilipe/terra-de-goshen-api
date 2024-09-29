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
                .ForPath(dest => dest.Price, opt => opt.MapFrom(src => new MoneyVO(src.Price)))
                .ForPath(dest => dest.CostPrice, opt => opt.MapFrom(src => new MoneyVO(src.CostPrice)))
                .ForPath(dest => dest.Stock, opt => opt.MapFrom(src => new StockVO(src.Stock)))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                .ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));

            CreateMap<Product, ProductResponseDTO>()
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Amount))
                .ForMember(dest => dest.CostPrice, opt => opt.MapFrom(src => src.CostPrice.Amount))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock.Amount))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                .ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));

            CreateMap<ProductUpdateDTO, Product>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ForPath(dest => dest.Price.Amount, opt => opt.MapFrom(src => src.Price))
                .ForPath(dest => dest.CostPrice.Amount, opt => opt.MapFrom(src => src.CostPrice))
                .ForPath(dest => dest.Stock.Amount, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                .ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));
        }
    }
}