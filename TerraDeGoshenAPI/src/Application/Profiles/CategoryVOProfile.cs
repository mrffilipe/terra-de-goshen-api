using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CategoryVOProfile : Profile
    {
        public CategoryVOProfile()
        {
            CreateMap<CategoryVO, string>().ConvertUsing(src => src.Name);
            CreateMap<string, CategoryVO>().ConvertUsing(src => new CategoryVO(src));
        }
    }
}