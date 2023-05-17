using eShopApi.Models;

namespace eShopApi.Interfaces
{
    public interface IAddress
    {
        Task<string> DeleteAddress(int addressId);
        Task<Address> GetAddress(int addressId);
        Task<Address> GetUserAddress(int userId);
        Task<List<Address>> GetAllAddress();
        Task<string> SaveAddress(Address address);
        Task<string> UpdateAddress(Address address);
    }
}
