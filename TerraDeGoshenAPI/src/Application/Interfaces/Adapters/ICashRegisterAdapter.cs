using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterAdapter
    {
        Task<TransactionResponseDTO> AddTransactionAsync(TransactionCreateDTO transaction);
        Task<decimal> GetCurrentBalanceAsync(Guid cashRegisterId);
        Task<IList<TransactionResponseDTO>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null);
    }
}