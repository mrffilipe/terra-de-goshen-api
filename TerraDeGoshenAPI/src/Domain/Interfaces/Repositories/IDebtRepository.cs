namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtRepository
    {
        Task<Debt> AddDebtAsync(Debt debt);
        Task<Debt> GetDebtByIdAsync(Guid id);
        Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId);
        Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount, DateTime paymentDate);
        Task<Installment> AddInstallmentToDebtAsync(Guid debtId, Installment installment);
        Task<bool> IsDebtFullyPaidAsync(Guid debtId);
    }
}