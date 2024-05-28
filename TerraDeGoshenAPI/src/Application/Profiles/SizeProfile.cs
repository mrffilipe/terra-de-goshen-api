using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<SizeCreateDTO, SizeRef>()
            .ConstructUsing(s => new SizeRef(
                new SizeVO(s.Value)
                ));

            CreateMap<SizeRef, SizeResponseDTO>()
                .ConstructUsing(s => new SizeResponseDTO(
                    s.Id,
                    s.Details.Value,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}