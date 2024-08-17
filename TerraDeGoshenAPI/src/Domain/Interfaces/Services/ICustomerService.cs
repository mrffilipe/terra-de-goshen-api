namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> GetCustomerByIdAsync(Guid id);
        Task<IList<Customer>> GetAllCustomersAsync();
        Task<Customer> UpdateCustomerAsync(Customer customer);
    }
}