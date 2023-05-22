using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class CartService
    {
        private readonly ICart _cartRepo;

        public CartService(ICart cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<string> DeleteCart(int cartId)
        {
            return await _cartRepo.DeleteCart(cartId);
        }

        public async Task<List<Cart>> GetAllCart()
        {
            return await _cartRepo.GetAllCart();
        }

       
        public async Task<string> SaveCart(Cart cart)
        {
            return await _cartRepo.SaveCart(cart);
        }

        public async Task<string> UpdateCart(Cart cart)
        {
            return await _cartRepo.UpdateCart(cart);
        }

      
    }
}
