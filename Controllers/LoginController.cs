using System.Threading.Tasks;
using Jewelry_Store_App.Models;
using Jewelry_Store_App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jewelry_Store_App.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Login login)
        {
            var result = await _loginService.LoginUser(login);
            return Ok(result);
        }
    }
}