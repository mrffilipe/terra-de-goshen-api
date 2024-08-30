using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class CashRegisterController : BaseController
    {
        [HttpPost]
        [Route("{cashRegisterId}/transactions")]
        public async Task<ActionResult<TransactionResponseDTO>> AddTransaction(Guid cashRegisterId, TransactionCreateDTO transaction)
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
        [Route("{cashRegisterId}/balance")]
        public async Task<ActionResult<TransactionResponseDTO>> GetCurrentBalance(Guid cashRegisterId)
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
        [Route("{cashRegisterId}/transactions")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactions(Guid cashRegisterId)
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