using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.src.Application;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerAdapter _customerAdapter;

        public CustomerController(ICustomerAdapter customerAdapter)
        {
            _customerAdapter = customerAdapter;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerResponseDTO>> AddCustomer([FromBody] CustomerCreateDTO customer)
        {
            try
            {
                return Ok(await _customerAdapter.AddCustomerAsync(customer));   
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
                return Ok(await _customerAdapter.GetCustomerByIdAsync(id));
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
                return Ok(await _customerAdapter.GetAllCustomersAsync());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<CustomerResponseDTO>> UpdateCustomer(Guid id, [FromBody] CustomerUpdateDTO customer)
        {
            try
            {
                return Ok(await _customerAdapter.UpdateCustomerAsync(customer));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception(ex.Message);
            }
        }
    }
}