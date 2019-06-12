using Microsoft.AspNetCore.Mvc;
using Praise.Contracts;
using Praize.Business.Managers;
using Praize.Contracts;
using Praize.Models;
using System.Threading.Tasks;

namespace Praize.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {

        private IAccountManager _accountManager;

        public AccountController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        [HttpPost]
        [Route("Account/Login")]
        public ApiResult<LoginResponseContract> Login(LoginRequestContract loginContract)
        {
            var result = new ApiResult<LoginResponseContract>();
            var data = new LoginResponseContract() { AccessToken = "Access Token", RefreshToken = "Refresh Token" };
            return result.Create("OK", EResponseCode.OK, data);
        }

        [HttpPost]
        [Route("Account/Register")]
        public void RegisterUser(RegisterUserContract registerUserContract)
        {
            _accountManager.CreateUser(registerUserContract);
        }
    }
}