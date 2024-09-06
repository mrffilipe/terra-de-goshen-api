using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class DebtController : BaseController
    {
        private readonly IDebtAdapter _debtAdapter;

        public DebtController(IDebtAdapter debtAdapter)
        {
            _debtAdapter = debtAdapter;
        }

        [HttpPost]
        public async Task<ActionResult<DebtResponseDTO>> AddDebt([FromBody] DebtCreateDTO debt)
        {
            try
            {
                return Ok(await _debtAdapter.AddDebtAsync(debt));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<DebtResponseDTO>> GetDebtById(Guid id)
        {
            try
            {
                return Ok(await _debtAdapter.GetDebtByIdAsync(id));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<DebtResponseDTO>>> GetAllDebts()
        {
            try
            {
                return Ok(await _debtAdapter.GetAllDebtsAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("{debtId}/installments")]
        public async Task<ActionResult<DebtResponseDTO>> AddInstallmentToDebt(Guid debtId, [FromBody] InstallmentCreateDTO installment)
        {
            try
            {
                return Ok(await _debtAdapter.AddInstallmentToDebtAsync(debtId, installment));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("installments/{installmentId}/payment")]
        public async Task<ActionResult<DebtResponseDTO>> RegisterInstallmentPayment(Guid installmentId, [FromBody] MoneyVO paymentAmount)
        {
            try
            {
                return Ok(await _debtAdapter.RegisterInstallmentPaymentAsync(installmentId, paymentAmount));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}