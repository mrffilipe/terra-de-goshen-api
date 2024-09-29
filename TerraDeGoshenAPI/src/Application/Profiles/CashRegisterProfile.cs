using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CashRegisterProfile : Profile
    {
        public CashRegisterProfile()
        {
            CreateMap<CashRegister, CashRegisterResponseDTO>()
                .ForMember(dest => dest.CurrentBalance, opt => opt.MapFrom(src => src.CurrentBalance.Amount));
        }
    }
}