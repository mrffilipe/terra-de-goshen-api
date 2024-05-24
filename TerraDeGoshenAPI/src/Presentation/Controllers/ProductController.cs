﻿using Microsoft.AspNetCore.Mvc;
using TerraDeGoshenAPI.Application;

namespace TerraDeGoshenAPI.src.Presentation
{
    public class ProductController : BaseController
    {
        private readonly IProductAdapter _productAdapter;

        public ProductController(IProductAdapter productAdapter)
        {
            _productAdapter = productAdapter;
        }

        [HttpPost]
        [Route("add-product")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> AddProduct([FromForm] ProductCreateDTO product)
        {
            try
            {
                return Ok(await _productAdapter.AddProduct(product));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("get-product-by-id")]
        public async Task<IActionResult> GetProductById([FromQuery] Guid id)
        {
            try
            {
                return Ok(await _productAdapter.GetProductById(id));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception();
            }
        }

        [HttpGet]
        [Route("get-all-products")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                return Ok(await _productAdapter.GetAllProducts());
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception();
            }
        }

        [HttpPut]
        [Route("update-product")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateProduct([FromForm] ProductUpdateDTO product)
        {
            try
            {
                return Ok(await _productAdapter.UpdateProduct(product));
            }
            catch (Exception ex)
            {
                // ...
                throw new Exception();
            }
        }
    }
}