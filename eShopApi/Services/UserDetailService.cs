using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class UserDetailService 
    {
        private readonly IUserDetail _userDetailRepo;

        public UserDetailService(IUserDetail userDetailRepo)
        {
            _userDetailRepo = userDetailRepo;
        }

        public async Task<string> SaveUserDetailAsync(UserDetail userDetail)
        {
            return await _userDetailRepo.SaveUserDetailAsync(userDetail);
        }

        public async Task<UserDetail> GetUserDetailAsync(int userId)
        {
            return await _userDetailRepo.GetUserDetailAsync(userId);
        }

        public async Task<List<UserDetail>> GetAllUserDetailsAsync()
        {
            return await _userDetailRepo.GetAllUserDetailsAsync();
        }

        public async Task<string> UpdateUserDetailAsync(UserDetail userDetail)
        {
            return await _userDetailRepo.UpdateUserDetailAsync(userDetail);
        }

        public async Task<string> DeleteUserDetailAsync(int userId)
        {
            return await _userDetailRepo.DeleteUserDetailAsync(userId);
        }

        public async Task<UserDetail> GetUserByEmailAsync(string emailId)
        {
            return await _userDetailRepo.GetUserByEmailAsync(emailId);
        }
    }
}