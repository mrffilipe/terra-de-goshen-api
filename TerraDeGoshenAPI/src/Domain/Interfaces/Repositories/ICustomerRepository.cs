namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer customer);
        Task<Customer> GetByIdAsync(Guid id);
        Task<IList<Customer>> GetAllAsync();
        Task<Customer> UpdateAsync(Customer customer);
    }
}