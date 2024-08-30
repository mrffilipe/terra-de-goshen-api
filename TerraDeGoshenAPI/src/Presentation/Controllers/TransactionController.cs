using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class TransactionController : BaseController
    {
        [HttpPost]
        public async Task<ActionResult<TransactionResponseDTO>> AddTransaction()
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
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionById(Guid id)
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
        [Route("customer/{customerId}")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionsByCustomer(Guid customerId)
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
        [Route("product/{productId}")]
        public async Task<ActionResult<TransactionResponseDTO>> GetTransactionsByProduct(Guid productId)
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