using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtProfile : Profile
    {
        public DebtProfile()
        {
            CreateMap<DebtCreateDTO, Debt>()
                .ForMember(dest => dest.Installments, opt => opt.Ignore())
                .ForPath(dest => dest.TotalAmount, opt => opt.MapFrom(src => new MoneyVO(src.TotalAmount)))
                .ForPath(dest => dest.InitialPayment, opt => opt.MapFrom(src => new MoneyVO(src.InitialPayment ?? 0)));

            CreateMap<Debt, DebtResponseDTO>()
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount.Amount))
                .ForMember(dest => dest.InitialPayment, opt => opt.MapFrom(src => src.InitialPayment.Amount))
                .ForMember(dest => dest.Installments, opt => opt.MapFrom(src => src.Installments))
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer));
        }
    }
}