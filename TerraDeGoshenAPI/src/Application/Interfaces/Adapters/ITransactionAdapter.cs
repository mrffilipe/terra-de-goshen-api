using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionAdapter
    {
        Task<TransactionResponseDTO> GetTransactionByIdAsync(Guid id);
        Task<IList<TransactionResponseDTO>> GetTransactionsByCustomerAsync(Guid customerId);
        Task<IList<TransactionResponseDTO>> GetTransactionsByProductAsync(Guid productId);
    }
}