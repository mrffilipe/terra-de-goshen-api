using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository), "O repositório de cliente não pode ser nulo.");
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "O cliente não pode ser nulo.");
            }

            return await _customerRepository.AddCustomerAsync(customer);
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(id));
            }

            var customer = await _customerRepository.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                throw new CustomerNotFoundException($"Cliente com ID {id} não encontrado.");
            }

            return customer;
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllCustomersAsync();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "O cliente não pode ser nulo.");
            }

            var updatedCustomer = await _customerRepository.UpdateCustomerAsync(customer);
            if (updatedCustomer == null)
            {
                throw new CustomerNotFoundException($"Cliente com ID {customer.Id} não encontrado para atualização.");
            }

            return updatedCustomer;
        }
    }
}