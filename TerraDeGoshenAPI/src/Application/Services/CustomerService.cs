using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var addedCustomer = await _customerRepository.AddCustomerAsync(customer);

            return addedCustomer;
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var customer = await _customerRepository.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                throw new KeyNotFoundException($"Cliente com ID {id} não encontrado.");
            }

            return customer;
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            var customers = await _customerRepository.GetAllCustomersAsync();

            return customers;
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var updatedCustomer = await _customerRepository.UpdateCustomerAsync(customer);

            return updatedCustomer;
        }
    }
}