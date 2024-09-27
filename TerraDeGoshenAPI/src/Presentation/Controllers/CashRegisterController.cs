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
        [Route("transactions")]
        public async Task<ActionResult<TransactionResponseDTO>> AddTransaction([FromBody] TransactionCreateDTO transaction)
        {
            try
            {
                return Ok(await _cashRegisterAdapter.AddTransactionAsync(transaction));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("balance")]
        public async Task<ActionResult<decimal>> GetCurrentBalance()
        {
            try
            {
                return Ok(await _cashRegisterAdapter.GetCurrentBalanceAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("transactions")]
        public async Task<ActionResult<IList<TransactionResponseDTO>>> GetTransactions(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                return Ok(await _cashRegisterAdapter.GetTransactionsAsync(startDate, endDate));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}