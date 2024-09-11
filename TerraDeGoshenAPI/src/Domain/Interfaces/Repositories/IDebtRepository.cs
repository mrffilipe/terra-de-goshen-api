namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtRepository
    {
        Task<Debt> AddDebtAsync(Debt debt);
        Task<Debt> GetDebtByIdAsync(Guid id);
        Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<Installment> GetInstallmentByIdAsync(Guid installmentId);
        Task<Installment> UpdateInstallmentAsync(Installment installment);
    }
}