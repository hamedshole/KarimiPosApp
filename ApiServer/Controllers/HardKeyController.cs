using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HardKeyController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public HardKeyController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody] HardwareKeyModel hardwareKey)
        {
            return Ok(this._unit.HardWarekey.Insert(hardwareKey));
        }
        [HttpPost("get")]
        public IActionResult Get([FromBody] HardwareKeyModel hardwareKey)
        {
            return Ok(this._unit.HardWarekey.List(hardwareKey));
        }
    }
}
