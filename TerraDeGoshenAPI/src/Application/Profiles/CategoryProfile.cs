using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<SimpleCategoryCreateDTO, CategoryRef>();

            CreateMap<CategoryRef, CategoryResponseDTO>()
                .ConstructUsing(src => new CategoryResponseDTO(src.Id, src.Details.Name, src.CreatedAt, src.UpdatedAt));

            CreateMap<CategoryUpdateDTO, CategoryRef>();
        }
    }
}