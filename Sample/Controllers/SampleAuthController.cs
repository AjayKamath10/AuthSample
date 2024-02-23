using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleAuthController : ControllerBase
    {
        // GET: api/<SampleAuthController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Task.FromResult("Good morning"));
        }

    }
}
