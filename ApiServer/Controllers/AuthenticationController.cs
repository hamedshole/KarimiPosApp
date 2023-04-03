using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IUnitOfWork _unit;

        public AuthenticationController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost("/login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            var res = _unit.Authentication.Login(user);
            return Ok(res);
        }
        [HttpPost]
        public IActionResult GetSettings([FromBody] UserRoleModel userRole)
        {
            return Ok(_unit.Authentication.GetUserSettings(userRole));
        }
    }
}
