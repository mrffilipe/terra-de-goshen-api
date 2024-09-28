using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CashRegisterService : ICashRegisterService
    {
        private readonly ICashRegisterRepository _cashRegisterRepository;

        public CashRegisterService(ICashRegisterRepository cashRegisterRepository)
        {
            _cashRegisterRepository = cashRegisterRepository ?? throw new ArgumentNullException(nameof(cashRegisterRepository), "O repositório de registro de caixa não pode ser nulo.");
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction), "A transação não pode ser nula.");
            }

            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();
            if (cashRegister == null)
            {
                throw new InvalidOperationException("Nenhum caixa encontrado.");
            }

            transaction.SetCashRegisterId(cashRegister.Id);

            return await _cashRegisterRepository.AddTransactionAsync(transaction);
        }

        public async Task<CashRegister> GetCashRegisterAsync()
        {
            return await _cashRegisterRepository.GetCashRegisterAsync();
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync()
        {
            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();
            if (cashRegister == null)
            {
                throw new InvalidOperationException("Nenhum caixa encontrado.");
            }

            var balance = await _cashRegisterRepository.GetCurrentBalanceAsync(cashRegister.Id);
            if (balance == null)
            {
                throw new InvalidOperationException("Não foi possível recuperar o saldo atual do caixa.");
            }

            return balance;
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(DateTime? startDate = null, DateTime? endDate = null)
        {
            var cashRegister = await _cashRegisterRepository.GetCashRegisterAsync();

            return await _cashRegisterRepository.GetTransactionsAsync(cashRegister.Id, startDate, endDate);
        }
    }
}