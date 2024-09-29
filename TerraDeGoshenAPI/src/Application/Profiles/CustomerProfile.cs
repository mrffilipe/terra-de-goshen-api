using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreateDTO, Customer>();

            CreateMap<Customer, CustomerResponseDTO>();

            CreateMap<CustomerUpdateDTO, Customer>();
        }
    }
}