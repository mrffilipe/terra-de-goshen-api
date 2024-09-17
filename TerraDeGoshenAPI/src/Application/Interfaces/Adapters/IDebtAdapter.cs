using TerraDeGoshenAPI.src.Application;

namespace TerraDeGoshenAPI.src.Domain
{
    public interface IDebtAdapter
    {
        Task<DebtResponseDTO> AddDebtAsync(Guid cashRegisterId, DebtCreateDTO debt);
        Task<DebtResponseDTO> GetDebtByIdAsync(Guid id);
        Task<IList<DebtResponseDTO>> GetDebtsByCustomerIdAsync(Guid customerId);
        Task<IList<DebtResponseDTO>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null);
        Task<InstallmentResponseDTO> RegisterInstallmentPaymentAsync(Guid installmentId, Guid cashRegisterId, decimal paymentAmount);
    }
}