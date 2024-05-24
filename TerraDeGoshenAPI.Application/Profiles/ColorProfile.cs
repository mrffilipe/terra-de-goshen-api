using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorCreateDTO, ColorRef>()
                .ConstructUsing(s => new ColorRef(
                    new ColorVO(s.Value)
                    ));

            CreateMap<ColorRef, ColorResponseDTO>()
                .ConstructUsing(s => new ColorResponseDTO(
                    s.Id,
                    s.Details.Value,
                    s.ImageId,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}