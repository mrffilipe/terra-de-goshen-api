using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CustomerAdapter : ICustomerAdapter
    {
        private readonly ICustomerService _customerService;

        public CustomerAdapter(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}