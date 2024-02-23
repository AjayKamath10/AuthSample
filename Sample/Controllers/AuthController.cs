using Microsoft.AspNetCore.Mvc;
using Sample.Services;
using Sample.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers
{
        [Route("api/v1/auth")]
        [ApiController]
        public class AuthController : ControllerBase
        {
            private readonly IAuthService _service;

            public AuthController(IAuthService service)
            {
                _service = service;
            }

            [HttpPost("login")]
            public async Task<IActionResult> LoginAsync(LoginViewModel viewModel)
            {
                return Ok(await _service.LoginAsync(viewModel));
            }

            [HttpPost("register")]
            public async Task<IActionResult> RegisterAsync(UserRegisterViewModel viewModel)
            {
                await _service.RegisterAsync(viewModel);
                return Ok();
            }
        }
    
}
