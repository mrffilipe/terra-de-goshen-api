using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterAdapter
    {
        Task<TransactionResponseDTO> AddTransactionAsync(TransactionCreateDTO transaction);
        Task<decimal> GetCurrentBalanceAsync();
        Task<IList<TransactionResponseDTO>> GetTransactionsAsync(DateTime? startDate = null, DateTime? endDate = null);
    }
}