using Microsoft.AspNetCore.Mvc;
using System.Net;
using Villa.Models;
using Villa.Models.DTO;
using Villa.Repository.IRepository;

namespace Villa.Controllers
{
    [Route("api/UserAuth")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        protected APIResponse response;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            this.response = new APIResponse();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
            {
            var loginResponse = await _userRepository.Login(model);
            if(loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.IsSuccess = false;
                response.ErrorsMessage.Add("UserName or Password is incorrect");
                return BadRequest(response);
            }
            response.StatusCode = HttpStatusCode.OK;
            response.IsSuccess = true;
            response.Result = loginResponse;
            return Ok(response);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO model)
        {
            bool uniqueUsername = _userRepository.IsUniqueUser(model.UserName);
            if(!uniqueUsername)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.IsSuccess = false;
                response.ErrorsMessage.Add("Username Already Exists");
                return BadRequest(response);
            }
            var user = await _userRepository.Register(model);
            if(user == null)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.IsSuccess = false;
                response.ErrorsMessage.Add("Error While Registering");
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
