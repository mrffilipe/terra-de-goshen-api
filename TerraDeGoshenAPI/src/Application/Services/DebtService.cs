using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _debtRepository;
        private readonly ICashRegisterService _cashRegisterService;

        public DebtService(IDebtRepository debtRepository, ICashRegisterService cashRegisterService)
        {
            _debtRepository = debtRepository ?? throw new ArgumentNullException(nameof(debtRepository), "O repositório de débito não pode ser nulo.");
            _cashRegisterService = cashRegisterService ?? throw new ArgumentNullException(nameof(cashRegisterService), "O serviço de registro de caixa não pode ser nulo.");
        }

        public async Task<Debt> AddDebtAsync(Debt debt)
        {
            if (debt == null) throw new ArgumentNullException(nameof(debt));

            if (debt.InstallmentCount <= 0)
                throw new ArgumentException("O número de parcelas deve ser maior que zero.", nameof(debt.InstallmentCount));

            if (debt.TotalAmount.Amount <= 0)
                throw new ArgumentException("O valor total da dívida deve ser maior que zero.", nameof(debt.TotalAmount));

            var remainingAmount = debt.TotalAmount.Amount - debt.InitialPayment.Amount;
            if (remainingAmount < 0)
                throw new InvalidOperationException("O pagamento inicial não pode ser maior que o valor total.");

            var installmentAmount = remainingAmount / debt.InstallmentCount;
            var installments = new List<Installment>();

            for (int i = 0; i < debt.InstallmentCount; i++)
            {
                var dueDate = debt.DueDate.AddMonths(i + 1);

                var installment = new Installment(
                    new MoneyVO(installmentAmount),
                    dueDate,
                    new MoneyVO(0),
                    false,
                    debt.CustomerId
                );
                installments.Add(installment);
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
            var cashRegister = await _cashRegisterService.GetCashRegisterAsync();

            if (debt.InitialPayment.Amount > 0)
            {
                var transaction = new Transaction(
                    new MoneyVO(debt.InitialPayment.Amount),
                    TransactionType.INCOME,
                    debt.PaymentMethod,
                    cashRegister.Id,
                    null,
                    debt.CustomerId
                );

                await _cashRegisterService.AddTransactionAsync(transaction);
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

        public async Task<IList<Debt>> GetDebtsByCustomerIdAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(customerId));
            }

            return await _debtRepository.GetDebtsByCustomerIdAsync(customerId);
        }

        public async Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            return await _debtRepository.GetAllDebtsAsync(startDate, endDate, isPaid);
        }

        public async Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount)
        {
            if (installmentId == Guid.Empty)
            {
                throw new ArgumentException("ID da parcela inválido.", nameof(installmentId));
            }

            if (paymentAmount == null || paymentAmount.Amount <= 0)
            {
                throw new ArgumentException("O valor de pagamento deve ser maior que zero.", nameof(paymentAmount));
            }

            var installment = await _debtRepository.GetInstallmentByIdAsync(installmentId);
            if (installment == null)
            {
                throw new KeyNotFoundException($"Parcela com ID {installmentId} não encontrada.");
            }

            installment.AddPayment(paymentAmount);

            var cashRegister = await _cashRegisterService.GetCashRegisterAsync();
            var transaction = new Transaction(
                paymentAmount,
                TransactionType.INCOME,
                installment.Debt.PaymentMethod,
                cashRegister.Id,
                null,
                installment.Debt.CustomerId
            );

            await _cashRegisterService.AddTransactionAsync(transaction);

            return await _debtRepository.UpdateInstallmentAsync(installment);
        }
    }
}