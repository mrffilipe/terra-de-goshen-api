using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _debtRepository;

        public DebtService(IDebtRepository debtRepository)
        {
            _debtRepository = debtRepository;
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