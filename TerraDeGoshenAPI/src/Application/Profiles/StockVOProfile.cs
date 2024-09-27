using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class StockVOProfile : Profile
    {
        public StockVOProfile()
        {
            CreateMap<StockVO, int>().ConvertUsing(src => src.Amount);
            CreateMap<int, StockVO>().ConvertUsing(src => new StockVO(src));
        }
    }
}