namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtRepository
    {
        Task<Debt> AddAsync(Debt debt);
        Task<Debt> GetByIdAsync(Guid id);
        Task<IList<Debt>> GetByCustomerIdAsync(Guid customerId);
        Task AddInstallmentAsync(Guid debtId, Installment installment);
        Task<bool> IsFullyPaidAsync(Guid debtId);
    }
}