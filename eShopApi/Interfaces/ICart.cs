using eShopApi.Models;

namespace eShopApi.Interfaces
{
    public interface ICart
    {
        Task<string> DeleteCart(int CartId);
        Task<List<Cart>> GetAllCart();
      
        Task<string> SaveCart(Cart cart);
        Task<string> UpdateCart(Cart cart);
       
    }
}
