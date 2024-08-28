using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CashRegisterAdapter : ICashRegisterAdapter
    {
        private readonly ICashRegisterService _cashRegisterService;

        public CashRegisterAdapter(ICashRegisterService cashRegisterService)
        {
            _cashRegisterService = cashRegisterService;
        }

        public async Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            throw new NotImplementedException();
        }
    }
}