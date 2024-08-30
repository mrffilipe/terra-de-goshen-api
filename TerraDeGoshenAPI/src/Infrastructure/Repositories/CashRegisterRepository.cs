using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CashRegisterRepository : ICashRegisterRepository
    {
        public Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            throw new NotImplementedException();
        }
    }
}