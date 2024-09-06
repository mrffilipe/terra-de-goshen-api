using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtAdapter
    {
        Task<DebtResponseDTO> AddDebtAsync(DebtCreateDTO debt);
        Task<DebtResponseDTO> GetDebtByIdAsync(Guid id);
        Task<IList<DebtResponseDTO>> GetDebtsByCustomerAsync(Guid customerId);
        Task<IList<DebtResponseDTO>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<InstallmentResponseDTO> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount);
        Task<InstallmentResponseDTO> AddInstallmentToDebtAsync(Guid debtId, InstallmentCreateDTO installment);
        Task<bool> IsDebtFullyPaidAsync(Guid debtId);
    }
}