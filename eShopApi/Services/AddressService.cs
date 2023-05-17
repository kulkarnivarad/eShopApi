using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class AddressService
    {
        private readonly IAddress _repository;

        public AddressService(IAddress repository)
        {
            _repository = repository;
        }

        // Deletes an address by ID
        public async Task<string> DeleteAddress(int addressId)
        {
            return await _repository.DeleteAddress(addressId);
        }

        // Gets an address by ID
        public async Task<Address> GetAddress(int addressId)
        {
            return await _repository.GetAddress(addressId);
        }

        // Gets an address by user ID
        public async Task<Address> GetUserAddress(int userId)
        {
            return await _repository.GetUserAddress(userId);
        }

        // Gets all addresses
        public async Task<List<Address>> GetAllAddress()
        {
            return await _repository.GetAllAddress();
        }

        // Adds a new address
        public async Task<string> SaveAddress(Address address)
        {
            return await _repository.SaveAddress(address);
        }

        // Updates an existing address
        public async Task<string> UpdateAddress(Address address)
        {
            return await _repository.UpdateAddress(address);
        }
    }
}
