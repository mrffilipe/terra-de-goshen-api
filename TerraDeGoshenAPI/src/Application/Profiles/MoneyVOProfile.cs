using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class MoneyVOProfile : Profile
    {
        public MoneyVOProfile()
        {
            CreateMap<MoneyVO, decimal>().ConvertUsing(src => src.Amount);
            CreateMap<decimal, MoneyVO>().ConvertUsing(src => new MoneyVO(src));
        }
    }
}