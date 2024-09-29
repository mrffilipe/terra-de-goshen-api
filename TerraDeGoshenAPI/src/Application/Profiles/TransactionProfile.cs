using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<TransactionCreateDTO, Transaction>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => new MoneyVO(src.Amount)));

            CreateMap<Transaction, TransactionResponseDTO>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount.Amount));
        }
    }
}