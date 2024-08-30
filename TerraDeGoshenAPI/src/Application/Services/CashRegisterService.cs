using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CashRegisterService : ICashRegisterService
    {
        private readonly ICashRegisterRepository _cashRegisterRepository;

        public CashRegisterService(ICashRegisterRepository cashRegisterRepository)
        {
            _cashRegisterRepository = cashRegisterRepository;
        }

        public async Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            throw new NotImplementedException();
        }
    }
}