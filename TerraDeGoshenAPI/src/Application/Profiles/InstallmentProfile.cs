using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class InstallmentProfile : Profile
    {
        public InstallmentProfile()
        {
            CreateMap<InstallmentCreateDTO, Installment>()
                .ForPath(dest => dest.Amount, opt => opt.MapFrom(src => new MoneyVO(src.Amount)))
                .ForMember(dest => dest.DebitId, opt => opt.MapFrom(src => src.DebitId));

            CreateMap<Installment, InstallmentResponseDTO>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.Amount))
                .ForMember(dest => dest.AmountPaid, opt => opt.MapFrom(src => src.AmountPaid.Amount));
        }
    }
}