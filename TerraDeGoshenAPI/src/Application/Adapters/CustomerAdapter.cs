using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CustomerAdapter : ICustomerAdapter
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerAdapter(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<CustomerResponseDTO> AddCustomerAsync(CustomerCreateDTO customer)
        {
            var mappedCustomer = _mapper.Map<Customer>(customer);

            mappedCustomer = await _customerService.AddCustomerAsync(mappedCustomer);

            return _mapper.Map<CustomerResponseDTO>(mappedCustomer);
        }

        public async Task<CustomerResponseDTO> GetCustomerByIdAsync(Guid id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);

            return _mapper.Map<CustomerResponseDTO>(customer);
        }

        public async Task<IList<CustomerResponseDTO>> GetAllCustomersAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();

            return _mapper.Map<CustomerResponseDTO[]>(customers);
        }

        public async Task<CustomerResponseDTO> UpdateCustomerAsync(CustomerUpdateDTO customer)
        {
            var mappedCustomer = _mapper.Map<Customer>(customer);

            mappedCustomer = await _customerService.UpdateCustomerAsync(mappedCustomer);

            return _mapper.Map<CustomerResponseDTO>(mappedCustomer);
        }
    }
}