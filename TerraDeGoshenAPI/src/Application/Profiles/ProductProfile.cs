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
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(dest => dest.Price.Amount, opt => opt.MapFrom(src => src.Price))
                .ForPath(dest => dest.CostPrice.Amount, opt => opt.MapFrom(src => src.CostPrice))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(dest => dest.Stock.Amount, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                .ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));

            CreateMap<Product, MinimumProductResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Amount))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

            CreateMap<Product, ProductResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Amount))
                .ForMember(dest => dest.CostPrice, opt => opt.MapFrom(src => src.CostPrice.Amount))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock.Amount))
                //.ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
                //.ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                //.ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

            CreateMap<ProductUpdateDTO, Product>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(dest => dest.Price.Amount, opt => opt.MapFrom(src => src.Price))
                .ForPath(dest => dest.CostPrice.Amount, opt => opt.MapFrom(src => src.CostPrice))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(dest => dest.Stock.Amount, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.Colors))
                .ForMember(dest => dest.Sizes, opt => opt.MapFrom(src => src.Sizes))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));
        }
    }
}