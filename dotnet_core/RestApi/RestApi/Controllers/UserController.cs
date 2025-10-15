using Microsoft.AspNetCore.Mvc;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok("Login Success");
        }

    }


}
