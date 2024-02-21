using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService userData;

        public UserController()
        {
            this.userData = new UserService();
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser([FromBody]UserWriteDTO user)
        {
            if (!user.Passwords.Equals(user.ConfirmPassword))
            {
                return BadRequest("PASSWORD_NOT_MATCH");
            }
 
            var response = await userData.CreateAccountUser(user);

            if (!response) 
            {
                return BadRequest("FAIL_CREATING_USER");
            }
            return Ok("SUCCESSFULLY_USER_CREATION");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LogInVerificationUser([FromBody] UserRequestDTO user)
        {
            var response = await userData.LogInUser(user);

            if (!response)
            {
                return Unauthorized("INVALID_CREDENTIAL");
            }
            else 
            {
                return Ok("SUCCESSFULLY_LOGIN");
            }
        }
    }
}
