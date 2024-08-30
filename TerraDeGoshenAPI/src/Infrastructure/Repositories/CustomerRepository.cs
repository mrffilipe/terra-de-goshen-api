using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> AddCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Customer>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}