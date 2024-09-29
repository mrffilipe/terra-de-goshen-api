using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<SimpleSizeCreateDTO, SizeRef>();

            CreateMap<SizeRef, SizeResponseDTO>()
                .ConstructUsing(src => new SizeResponseDTO(src.Id, src.Details.Value, src.CreatedAt, src.UpdatedAt));

            CreateMap<SizeUpdateDTO, SizeRef>();
        }
    }
}