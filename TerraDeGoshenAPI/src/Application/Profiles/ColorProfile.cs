using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<SimpleColorCreateDTO, ColorRef>();

            CreateMap<ColorRef, ColorResponseDTO>()
                .ConstructUsing(src => new ColorResponseDTO(src.Id, src.Details.Value, src.CreatedAt, src.UpdatedAt));

            CreateMap<ColorUpdateDTO, ColorRef>();
        }
    }
}