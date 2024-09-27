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

        public async Task<IList<DebtResponseDTO>> GetDebtsByCustomerIdAsync(Guid customerId)
        {
            var debt = await _debtService.GetDebtsByCustomerIdAsync(customerId);

            return _mapper.Map<DebtResponseDTO[]>(debt);
        }

        public async Task<IList<DebtResponseDTO>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var debs = await _debtService.GetAllDebtsAsync(startDate, endDate, isPaid);

            return _mapper.Map<DebtResponseDTO[]>(debs);
        }

        public async Task<InstallmentResponseDTO> RegisterInstallmentPaymentAsync(Guid installmentId, decimal paymentAmount)
        {
            var mappedPaymentAmount = _mapper.Map<MoneyVO>(paymentAmount);

            var installment = await _debtService.RegisterInstallmentPaymentAsync(installmentId, mappedPaymentAmount);

            return _mapper.Map<InstallmentResponseDTO>(installment);
        }
    }
}