using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IUnitOfWork _unit;


        [HttpPost]
        public IActionResult Close([FromBody] BatchModel batch)
        {
            return Ok(_unit.Batch.Close(batch));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Batch.Getall());
        }
    }
}
