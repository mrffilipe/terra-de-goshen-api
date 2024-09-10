namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtRepository
    {
        Task<Debt> AddDebtAsync(Debt debt);
        Task<Debt> GetDebtByIdAsync(Guid id);
        Task<Installment> GetInstallmentByIdAsync(Guid installmentId);
        Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId);
        Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount, DateTime paymentDate);
        Task<Installment> AddInstallmentToDebtAsync(Guid debtId, Installment installment);
        Task<bool> IsDebtFullyPaidAsync(Guid debtId);
        Task<Installment> UpdateInstallmentAsync(Installment installment);
    }
}