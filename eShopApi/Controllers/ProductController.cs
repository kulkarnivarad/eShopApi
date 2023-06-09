﻿using eShopApi.Models;
using eShopApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // POST: api/Product
        [HttpPost]
        public async Task<IActionResult> SaveProduct([FromBody] Product product)
        {
            await _productService.SaveProductAsync(product);
            return Ok();
        }


        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _productService.GetProductAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        // PUT: api/Product/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateProduct( Product product)
        //{

        //    await _productService.UpdateProductAsync(product);
        //    return Ok();
        //}
        //[HttpPut("UpdateProduct")]
        //public async Task<IActionResult> UpdateProduct(Product product)
        //{
        //    var updatedProduct = await _productService.UpdateProductAsync(product);
        //    return Ok(updatedProduct);
        //}
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProducte(Product Product)
        {
            return Ok(_productService.UpdateProduct(Product));
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok();
        }

        // GET: api/Product/category/{category}
        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsByCategory(string category)
        {
            var products = await _productService.GetProductsByCategoryAsync(category);
            return Ok(products);
        }
    }
}
