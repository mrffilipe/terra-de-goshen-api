using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<SizeCreateDTO, SizeRef>()
                .ForPath(dest => dest.Details.Value, opt => opt.MapFrom(src => src.Value));

            CreateMap<SimpleSizeCreateDTO, SizeRef>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<SizeRef, SizeResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Details.Value))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

            CreateMap<SizeUpdateDTO, SizeRef>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
        }
    }
}