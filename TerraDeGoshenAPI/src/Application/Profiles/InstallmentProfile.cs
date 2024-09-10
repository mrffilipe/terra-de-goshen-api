using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class InstallmentProfile : Profile
    {
        public InstallmentProfile()
        {
            CreateMap<InstallmentCreateDTO, Installment>()
                .ForPath(dest => dest.Amount.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.DebitId, opt => opt.MapFrom(src => src.DebitId));

            CreateMap<Installment, InstallmentResponseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.Amount))
                .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate))
                .ForMember(dest => dest.AmountPaid, opt => opt.MapFrom(src => src.AmountPaid.Amount))
                .ForMember(dest => dest.IsPaid, opt => opt.MapFrom(src => src.IsPaid))
                .ForMember(dest => dest.Debt, opt => opt.MapFrom(src => src.Debt))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
        }
    }
}