using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> AddAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}