using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class TransactionController : BaseController
    {
        private readonly ITransactionAdapter _transactionAdapter;

        public TransactionController(ITransactionAdapter transactionAdapter)
        {
            _transactionAdapter = transactionAdapter;
        }

        [HttpPost]
        public async Task<ActionResult<TransactionResponseDTO>> AddTransaction([FromBody] TransactionCreateDTO transaction)
        {
            try
            {
                return Ok(await _transactionAdapter.AddTransactionAsync(transaction));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionById(Guid id)
        {
            try
            {
                return Ok(await _transactionAdapter.GetTransactionByIdAsync(id));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("customer/{customerId}")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionsByCustomer(Guid customerId)
        {
            try
            {
                return Ok(await _transactionAdapter.GetTransactionsByCustomerAsync(customerId));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("product/{productId}")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionsByProduct(Guid productId)
        {
            try
            {
                return Ok(await _transactionAdapter.GetTransactionsByProductAsync(productId));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}