using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Pinterest.Payloads.DataRequests.TokenRequests;
using Project_Pinterest.Payloads.DataRequests.UserRequests;
using Project_Pinterest.Payloads.DataResponses.DataToken;
using Project_Pinterest.Payloads.DataResponses.DataUser;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(Request_Register request)
        {
            var result = await _authService.Register(request);
            return Ok(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(Request_Login request)
        {
            return Ok(await _authService.Login(request));
        }
        [HttpPost("RenewAccessToken")]
        public IActionResult RenewAccessToken(Request_Token request)
        {
            return Ok(_authService.RenewAccessToken(request));
        }
        [HttpPost("ConfirmCreateNewPassword")]
        public async Task<IActionResult> ConfirmCreateNewPassword(Request_ConfirmNewPassword request)
        {
            return Ok(await _authService.ConfirmCreateNewPassword(request));
        }
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(Request_ForgotPassword request)
        {
            return Ok(await _authService.ForgotPassword(request));
        }
        [HttpPost("ConfirmCreateNewAccount")]
        public async Task<IActionResult> ConfirmCreateNewAccount(Request_ConfirmCreateNewAccount request)
        {
            return Ok(await _authService.ConfirmCreateNewAccount(request));
        }
        [HttpPut("ChangePassword")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ChangePassword(Request_ChangePassword request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _authService.ChangePassword(id, request));
        }
    }
}
