using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class UserRoleController : ControllerBase
    {
        private   readonly IUnitOfWork _unit;

        public UserRoleController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]UserRoleModel userRole)
        {
            return Ok(_unit.UserRole.Insert(userRole));
        }
        [HttpPut]
        public IActionResult Put([FromBody]UserRoleModel userRole)
        {
            return Ok(_unit.UserRole.Update(userRole));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]UserRoleModel userRole)
        {
            return Ok(_unit.UserRole.Delete(userRole));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.UserRole.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

        [HttpPost("[Action]")]
        public IActionResult Get([FromBody] string userRole)
        {
            try
            {
                return Ok(_unit.UserRole.Get(userRole));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
