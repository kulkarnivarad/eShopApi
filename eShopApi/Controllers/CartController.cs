using eShopApi.Models;
using eShopApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    { 
            private readonly CartService _cartService;
                
            public CartController(CartService cartService)
            { 
                _cartService = cartService;
            }

            // POST api/cart
            [HttpPost]
            public async Task<ActionResult<string>> SaveCart([FromBody] Cart cart)
            {
            var result = await _cartService.SaveCart(cart);
            if (result == "Saved the Cart")
                return Ok(cart);
            else
                return BadRequest(result);
            }

            // GET api/cart
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Cart>>> GetAllCarts()
            {
                var carts = await _cartService.GetAllCart();
                return Ok(carts);
            }

        
        // PUT api/cart/5
        [HttpPut("{id}")]
            public async Task<ActionResult<string>> UpdateCart(int id, [FromBody] Cart cart)
            {
                if (id != cart.CartId)
                    return BadRequest("Invalid ID");

                var result = await _cartService.UpdateCart(cart);
                if (result == "Updated the Cart")
                    return Ok(result);
                else
                    return BadRequest(result);
            }

            // DELETE api/cart/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<string>> DeleteCart(int id)
            {
                var result = await _cartService.DeleteCart(id);
                if (result == "Deleted the Cart")
                    return Ok(result);
                else
                    return BadRequest(result);
            }

            

            
        }
}
