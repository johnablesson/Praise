using Microsoft.AspNetCore.Mvc;
using Praise.Contracts;
using Praize.Models;

namespace Praize.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Account/Login")]
        public ApiResult<LoginResponseContract> Login(LoginRequestContract loginContract)
        {
            var result = new ApiResult<LoginResponseContract>();
            var data = new LoginResponseContract() { AccessToken = "Access Token", RefreshToken = "Refresh Token" };
            return result.Create("OK", EResponseCode.OK, data);
        }
    }
}