using AutoMapper;
using TerraDeGoshenAPI.Domain;

namespace TerraDeGoshenAPI.Application
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
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