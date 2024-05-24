using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
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