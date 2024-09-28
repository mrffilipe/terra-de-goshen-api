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
        [Route("customer/{customerId}")]
        public async Task<ActionResult<IList<DebtResponseDTO>>> GetDebtsByCustomerId(Guid customerId)
        {
            try
            {
                return Ok(await _debtAdapter.GetDebtsByCustomerIdAsync(customerId));
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
        [Route("installment/{installmentId}/payment")]
        public async Task<ActionResult<DebtResponseDTO>> RegisterInstallmentPayment(Guid installmentId, [FromBody] decimal paymentAmount)
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