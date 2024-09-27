namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtService
    {
        Task<Debt> AddDebtAsync(Debt debt);
        Task<Debt> GetDebtByIdAsync(Guid id);
        Task<IList<Debt>> GetDebtsByCustomerIdAsync(Guid customerId);
        Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount);
    }
}