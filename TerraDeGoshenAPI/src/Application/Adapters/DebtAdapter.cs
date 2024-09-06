using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class DebtAdapter : IDebtAdapter
    {
        private readonly IDebtService _debtService;
        private readonly IMapper _mapper;

        public DebtAdapter(IDebtService debtService, IMapper mapper)
        {
            _debtService = debtService;
            _mapper = mapper;
        }

        public async Task<DebtResponseDTO> AddDebtAsync(DebtCreateDTO debt)
        {
            var mappedDebt = _mapper.Map<Debt>(debt);   

            mappedDebt = await _debtService.AddDebtAsync(mappedDebt);

            return _mapper.Map<DebtResponseDTO>(mappedDebt);
        }

        public async Task<DebtResponseDTO> GetDebtByIdAsync(Guid id)
        {
            var debt = await _debtService.GetDebtByIdAsync(id);

            return _mapper.Map<DebtResponseDTO>(debt);
        }

        public async Task<IList<DebtResponseDTO>> GetDebtsByCustomerAsync(Guid customerId)
        {
            var debts = await _debtService.GetDebtsByCustomerAsync(customerId);

            return _mapper.Map<DebtResponseDTO[]>(debts);
        }

        public async Task<IList<DebtResponseDTO>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var debs = await _debtService.GetAllDebtsAsync(startDate, endDate, isPaid);

            return _mapper.Map<DebtResponseDTO[]>(debs);
        }

        public async Task<InstallmentResponseDTO> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount)
        {
            var installment = await _debtService.RegisterInstallmentPaymentAsync(installmentId, paymentAmount);

            return _mapper.Map<InstallmentResponseDTO>(installment);
        }

        public async Task<InstallmentResponseDTO> AddInstallmentToDebtAsync(Guid debtId, InstallmentCreateDTO installment)
        {
            var mappedInstallment = _mapper.Map<Installment>(installment);

            mappedInstallment = await _debtService.AddInstallmentToDebtAsync(debtId, mappedInstallment);

            return _mapper.Map<InstallmentResponseDTO>(mappedInstallment);
        }

        public Task<bool> IsDebtFullyPaidAsync(Guid debtId)
        {
            return _debtService.IsDebtFullyPaidAsync(debtId);
        }
    }
}