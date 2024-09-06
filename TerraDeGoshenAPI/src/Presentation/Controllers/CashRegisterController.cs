using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class CashRegisterController : BaseController
    {
        private readonly ICashRegisterAdapter _cashRegisterAdapter;

        public CashRegisterController(ICashRegisterAdapter cashRegisterAdapter)
        {
            _cashRegisterAdapter = cashRegisterAdapter;
        }

        [HttpPost]
        [Route("{cashRegisterId}/transactions")]
        public async Task<ActionResult<TransactionResponseDTO>> AddTransaction(Guid cashRegisterId, [FromBody] TransactionCreateDTO transaction)
        {
            try
            {
                return Ok(await _cashRegisterAdapter.AddTransactionAsync(cashRegisterId, transaction));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{cashRegisterId}/balance")]
        public async Task<ActionResult<decimal>> GetCurrentBalance(Guid cashRegisterId)
        {
            try
            {
                return Ok(await _cashRegisterAdapter.GetCurrentBalanceAsync(cashRegisterId));
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
                return Ok(await _cashRegisterAdapter.GetTransactionsAsync(cashRegisterId));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}