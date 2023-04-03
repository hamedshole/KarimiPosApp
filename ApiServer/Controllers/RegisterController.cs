using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public RegisterController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]RegisterModel register)
        {
            return Ok(_unit.Register.Insert(register));
        }
        [HttpPut]
        public IActionResult Put([FromBody] RegisterModel register)
        {
            return Ok(_unit.Register.Update(register));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]RegisterModel register)
        {
            return Ok(_unit.Register.Delete(register));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(_unit.Register.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Register.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(_unit.Register.Search(text));
        }
        
    }
}
