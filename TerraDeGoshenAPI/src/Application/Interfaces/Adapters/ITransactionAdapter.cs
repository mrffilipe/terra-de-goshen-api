using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionAdapter
    {
        Task<TransactionResponseDTO> AddTransactionAsync(TransactionCreateDTO transaction);
        Task<TransactionResponseDTO> GetTransactionByIdAsync(Guid id);
        Task<IList<TransactionResponseDTO>> GetTransactionsByCustomerAsync(Guid customerId);
        Task<IList<TransactionResponseDTO>> GetTransactionsByProductAsync(Guid productId);
        Task<IList<TransactionResponseDTO>> GetTransactionsByCashRegisterAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null);
    }
}