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

        public Task<Debt> AddDebtAsync(Debt debt)
        {
            throw new NotImplementedException();
        }

        public Task<Debt> GetDebtByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            throw new NotImplementedException();
        }

        public Task RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount, DateTime paymentDate)
        {
            throw new NotImplementedException();
        }

        public Task AddInstallmentToDebtAsync(Guid debtId, Installment installment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsDebtFullyPaidAsync(Guid debtId)
        {
            throw new NotImplementedException();
        }
    }
}