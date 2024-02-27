using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Models;
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

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUsername([FromRoute] string username)
        {
            var response = await userData.ReadUserInfo(username);
            if(response == null)
            {
                return BadRequest("FAIL_LOCATING_USER");
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserWriteDTO user)
        {
            if (!user.Passwords.Equals(user.ConfirmPassword))
            {
                return BadRequest("PASSWORD_NOT_MATCH");
            }

            var isUsernameTaken = await userData.IsUsernameTaken(user.UserNames);
            if (isUsernameTaken)
            {
                return BadRequest("USERNAME_ALREADY_EXISTS");
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] string id)
        {
            var response = await userData.DeleteUserById(id);

            if (id != null)
            {
                if (!response)
                {
                    return BadRequest("FAIL_DELETING_USER");
                }
                else
                {
                    return Ok("USER_SUCCESSFULLY_DELETED");
                }
            }
            return BadRequest("INVALID_ID");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditUser([FromRoute] string id, [FromBody] UserWriteDTO userWriteDTO)
        {
            var response = await userData.EditUserById(id, userWriteDTO);

            if (id != null)
            {
                if (!response)
                {
                    return BadRequest("FAIL_EDITING_USER");
                }
                else
                {
                    return Ok("USER_SUCCESSFULLY_EDITED");
                }
            }
            return BadRequest("INVALID_ID");
        }
        

    }
}
