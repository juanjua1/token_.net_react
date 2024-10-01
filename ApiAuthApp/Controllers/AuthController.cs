using Microsoft.AspNetCore.Mvc;
using ApiAuthApp.Models;
using ApiAuthApp.Services;

namespace ApiAuthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var user = _userService.Authenticate(loginDto.Username, loginDto.Password);
            
            if (user == null)
                return Unauthorized();

            // Generar JWT y devolverlo
            return Ok(new { Token = "your_jwt_token" });
        }
    }
}
