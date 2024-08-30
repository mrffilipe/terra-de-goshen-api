using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class DebtController : BaseController
    {
        [HttpPost]
        public async Task<ActionResult<DebtResponseDTO>> AddDebt(DebtCreateDTO debt)
        {
            try
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("{debtId}/installments")]
        public async Task<ActionResult<DebtResponseDTO>> AddInstallmentToDebt(Guid debtId, InstallmentCreateDTO installment)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [Route("installments/{installmentId}/payment")]
        public async Task<ActionResult<DebtResponseDTO>> RegisterInstallmentPayment(Guid installmentId, MoneyVO paymentAmount)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}