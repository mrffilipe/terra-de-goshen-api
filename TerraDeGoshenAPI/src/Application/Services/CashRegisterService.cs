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

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            var addedTransaction = await _cashRegisterRepository.AddTransactionAsync(transaction);

            return addedTransaction;
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            var currentBalance = await _cashRegisterRepository.GetCurrentBalanceAsync(cashRegisterId);

            return currentBalance;
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var transactions = await _cashRegisterRepository.GetTransactionsAsync(cashRegisterId, startDate, endDate);

            return transactions;
        }
    }
}