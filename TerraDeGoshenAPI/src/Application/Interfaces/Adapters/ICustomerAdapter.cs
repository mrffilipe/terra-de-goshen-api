using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICustomerAdapter
    {
        Task<CustomerResponseDTO> AddCustomerAsync(CustomerCreateDTO customer);
        Task<CustomerResponseDTO> GetCustomerByIdAsync(Guid id);
        Task<IList<CustomerResponseDTO>> GetAllCustomersAsync();
        Task<CustomerResponseDTO> UpdateCustomerAsync(CustomerUpdateDTO customer);
    }
}