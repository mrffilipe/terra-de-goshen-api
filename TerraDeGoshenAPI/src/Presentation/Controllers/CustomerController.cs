using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class CustomerController : BaseController
    {
        [HttpPost]
        public async Task<ActionResult<CustomerResponseDTO>> AddCustomer(CustomerCreateDTO customer)
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
        public async Task<ActionResult<CustomerResponseDTO>> GetCustomerById(Guid id)
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
        public async Task<ActionResult<IList<CustomerResponseDTO>>> GetAllCustomers()
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

        [HttpPut]
        public async Task<ActionResult<CustomerResponseDTO>> UpdateCustomer(CustomerUpdateDTO customer)
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