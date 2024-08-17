namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtService
    {
        Task<Debt> AddDebtAsync(Debt debt);
        Task<Debt> GetDebtByIdAsync(Guid id);
        Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId);
        Task AddInstallmentToDebtAsync(Guid debtId, Installment installment);
        Task<bool> IsDebtFullyPaidAsync(Guid debtId);
    }
}