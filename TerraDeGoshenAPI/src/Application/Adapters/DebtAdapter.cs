using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtAdapter : IDebtAdapter
    {
        private readonly IDebtService _debtService;

        public DebtAdapter(IDebtService debtService)
        {
            _debtService = debtService;
        }

        public async Task<Debt> AddDebtAsync(Debt debt)
        {
            throw new NotImplementedException();
        }

        public async Task<Debt> GetDebtByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public async Task AddInstallmentToDebtAsync(Guid debtId, Installment installment)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsDebtFullyPaidAsync(Guid debtId)
        {
            throw new NotImplementedException();
        }
    }
}