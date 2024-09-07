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
            if (debt == null)
            {
                throw new ArgumentNullException(nameof(debt));
            }

            var addedDebt = await _debtRepository.AddDebtAsync(debt);

            return addedDebt;
        }

        public async Task<Debt> GetDebtByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var debt = await _debtRepository.GetDebtByIdAsync(id);
            if (debt == null)
            {
                throw new KeyNotFoundException($"Dívida com ID {id} não encontrada.");
            }

            return debt;
        }

        public async Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(customerId));
            }

            var debts = await _debtRepository.GetDebtsByCustomerAsync(customerId);

            return debts;
        }

        public async Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var debts = await _debtRepository.GetAllDebtsAsync(startDate, endDate, isPaid);

            return debts;
        }

        public async Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount)
        {
            if (installmentId == Guid.Empty)
            {
                throw new ArgumentException("ID da parcela inválido.", nameof(installmentId));
            }

            if (paymentAmount == null)
            {
                throw new ArgumentNullException(nameof(paymentAmount));
            }

            var installment = await _debtRepository.RegisterInstallmentPaymentAsync(installmentId, paymentAmount, DateTime.UtcNow);

            return installment;
        }

        public async Task<Installment> AddInstallmentToDebtAsync(Guid debtId, Installment installment)
        {
            if (debtId == Guid.Empty)
            {
                throw new ArgumentException("ID da dívida inválido.", nameof(debtId));
            }

            if (installment == null)
            {
                throw new ArgumentNullException(nameof(installment));
            }

            var addedInstallment = await _debtRepository.AddInstallmentToDebtAsync(debtId, installment);

            return addedInstallment;
        }

        public async Task<bool> IsDebtFullyPaidAsync(Guid debtId)
        {
            if (debtId == Guid.Empty)
            {
                throw new ArgumentException("ID da dívida inválido.", nameof(debtId));
            }

            var isFullyPaid = await _debtRepository.IsDebtFullyPaidAsync(debtId);

            return isFullyPaid;
        }
    }
}