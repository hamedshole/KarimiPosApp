using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public UserController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]UserModel user)
        {
            return Ok(this._unit.User.Insert(user));
        }
        [HttpPut]
        public IActionResult Put([FromBody]UserModel user)
        {
            return Ok(this._unit.User.Update(user));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]UserModel user)
        {
            return Ok(this._unit.User.Delete(user));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(this._unit.User.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.User.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(this._unit.User.Search(text));
        }
    }
}
