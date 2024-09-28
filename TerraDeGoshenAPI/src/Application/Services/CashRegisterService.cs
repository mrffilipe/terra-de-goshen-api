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

            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();

            //transaction.SetCashRegisterId(cashRegister.Id);

            var addedTransaction = await _cashRegisterRepository.AddTransactionAsync(transaction);

            return addedTransaction;
        }

        public async Task<CashRegister> GetCashRegisterAsync()
        {
            return await _cashRegisterRepository.GetCashRegisterAsync();
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync()
        {
            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();

            var currentBalance = await _cashRegisterRepository.GetCurrentBalanceAsync(cashRegister.Id);

            return currentBalance;
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(DateTime? startDate = null, DateTime? endDate = null)
        {
            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();

            var transactions = await _cashRegisterRepository.GetTransactionsAsync(cashRegister.Id, startDate, endDate);

            return transactions;
        }
    }
}