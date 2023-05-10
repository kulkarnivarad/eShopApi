using Microsoft.AspNetCore.Mvc;
using eShopApi.Models;
using eShopApi.Services;

namespace eShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : Controller
    {
        private readonly UserDetailService _userDetailService;

        public UserDetailController(UserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }

        // POST api/userdetail
        [HttpPost]
        public async Task<ActionResult<string>> SaveUserDetail(UserDetail userDetail)
        {
            var response = await _userDetailService.SaveUserDetailAsync(userDetail);
            return Ok(response);
        }

        // GET api/userdetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDetail>>> GetAllUserDetails()
        {
            var userDetails = await _userDetailService.GetAllUserDetailsAsync();
            return Ok(userDetails);
        }


        // GET api/userdetail/5
        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDetail>> GetUserDetail(int userId)
        {
            var userDetail = await _userDetailService.GetUserDetailAsync(userId);
            if (userDetail == null)
            {
                return NotFound();
            }
            return userDetail;
        }

        // GET api/userdetail/email/{emailId}
        [HttpGet("email/{emailId}")]
        public async Task<ActionResult<UserDetail>> GetUserByEmail(string emailId)
        {
            var userDetail = await _userDetailService.GetUserByEmailAsync(emailId);
            if (userDetail == null)
            {
                return NotFound();
            }
            return userDetail;
        }


        // PUT api/userdetail
        [HttpPut("{userId}")]
        public async Task<ActionResult<string>> UpdateUserDetail(int userId, UserDetail userDetail)
        {
            if (userId != userDetail.UserId)
            {
                return BadRequest();
            }
            var response = await _userDetailService.UpdateUserDetailAsync(userDetail);
            return Ok(response);
        }

        // DELETE api/userdetail/5
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUserDetail(int userId)
        {
            try
            {
                var response = await _userDetailService.DeleteUserDetailAsync(userId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting user detail with id {userId}: {ex.Message}\n");

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the user detail.");
            }
        }


    }
    
}