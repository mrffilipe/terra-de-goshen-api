using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryCreateDTO, CategoryRef>()
                .ConstructUsing(s => new CategoryRef(
                    new CategoryVO(s.Name)
                    ));

            CreateMap<CategoryRef, CategoryResponseDTO>()
                .ConstructUsing(s => new CategoryResponseDTO(
                    s.Id,
                    s.Details.Name,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}