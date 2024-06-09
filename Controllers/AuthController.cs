
using AuthenticationAPIJWT.Dtos.Auth;
using AuthenticationAPIJWT.Dtos.Shared;
using AuthenticationAPIJWT.Models;
using AuthenticationAPIJWT.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPIJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly AuthUtil _authUtil;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
            this._authUtil = new AuthUtil(this._configuration);
        }


        [HttpPost("SignIn")]
        public IActionResult SignIn(LoginUser loginUser)
        {
            User user = this._authUtil.Authenticate(loginUser);
            if (user is not null)
            {
                string token = this._authUtil.GenerateJWT(user);
                return Ok(new HttpResponseDTO<SignInResponse>(200, "User authenticate success", new List<SignInResponse>
                    {
                        new SignInResponse(token, user)
                    }));
            }

            return NotFound(new HttpResponseDTO<SignInResponse>(404, "Not Found user"));
        }
    }
}
