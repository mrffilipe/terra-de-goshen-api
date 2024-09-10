using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _debtRepository;
        private readonly ICashRegisterService _cashRegisterService;

        public DebtService(IDebtRepository debtRepository, ICashRegisterService cashRegisterService)
        {
            _debtRepository = debtRepository;
            _cashRegisterService = cashRegisterService;
        }

        public async Task<Debt> AddDebtAsync(Guid cashRegisterId, Debt debt)
        {
            if (debt == null)
            {
                throw new ArgumentNullException(nameof(debt));
            }

            var remainingAmount = debt.TotalAmount.Amount - debt.InitialPayment.Amount;
            var installmentAmount = remainingAmount / debt.InstallmentCount;

            var installments = new List<Installment>();

            for (int i = 0; i < debt.InstallmentCount; i++)
            {
                var dueDate = debt.DueDate.AddMonths(i);

                if (i == 0 && debt.InitialPayment.Amount > 0)
                {
                    var firstInstallment = new Installment(
                        new MoneyVO(installmentAmount),
                        new MoneyVO(debt.InitialPayment.Amount),
                        true,
                        debt.CustomerId
                    );

                    installments.Add(firstInstallment);
                }
                else
                {
                    var installment = new Installment(
                        new MoneyVO(installmentAmount),
                        new MoneyVO(0),
                        false,
                        debt.CustomerId
                    );

                    installments.Add(installment);
                }
            }

            var calculatedDebt = new Debt(
                new MoneyVO(debt.TotalAmount.Amount),
                debt.DueDate,
                debt.InstallmentCount,
                debt.PaymentMethod,
                new MoneyVO(debt.InitialPayment.Amount),
                installments,
                debt.CustomerId
            );

            var addedDebt = await _debtRepository.AddDebtAsync(calculatedDebt);

            if (debt.InitialPayment.Amount > 0)
            {
                var initialInstallment = installments.FirstOrDefault(i => i.IsPaid);

                if (initialInstallment != null)
                {
                    var transaction = new Transaction(
                        new MoneyVO(initialInstallment.AmountPaid.Amount),
                        TransactionType.INCOME,
                        debt.PaymentMethod,
                        cashRegisterId,
                        productId: null,
                        customerId: debt.CustomerId
                    );

                    await _cashRegisterService.AddTransactionAsync(transaction.CashRegisterId, transaction);
                }
            }

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

        public async Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, Guid cashRegisterId, MoneyVO paymentAmount)
        {
            if (installmentId == Guid.Empty)
            {
                throw new ArgumentException("ID da parcela inválido.", nameof(installmentId));
            }

            if (paymentAmount == null)
            {
                throw new ArgumentNullException(nameof(paymentAmount));
            }

            var installment = await _debtRepository.GetInstallmentByIdAsync(installmentId);
            if (installment == null)
            {
                throw new KeyNotFoundException($"Parcela com ID {installmentId} não encontrada.");
            }

            if (paymentAmount.Amount <= 0)
            {
                throw new ArgumentException("O valor de pagamento deve ser maior que zero.", nameof(paymentAmount));
            }

            installment.AddPayment(paymentAmount);

            var transaction = new Transaction(
                paymentAmount,
                TransactionType.INCOME,
                installment.Debt.PaymentMethod,
                cashRegisterId,
                productId: null,
                customerId: installment.Debt.CustomerId
            );

            await _cashRegisterService.AddTransactionAsync(transaction.CashRegisterId, transaction);

            await _debtRepository.UpdateInstallmentAsync(installment);

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