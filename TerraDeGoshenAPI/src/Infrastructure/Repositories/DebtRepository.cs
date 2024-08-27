using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class DebtRepository : IDebtRepository
    {
        public async Task<Debt> AddAsync(Debt debt)
        {
            throw new NotImplementedException();
        }

        public async Task<Debt> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Debt>> GetByCustomerIdAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public async Task AddInstallmentAsync(Guid debtId, Installment installment)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsFullyPaidAsync(Guid debtId)
        {
            throw new NotImplementedException();
        }
    }
}