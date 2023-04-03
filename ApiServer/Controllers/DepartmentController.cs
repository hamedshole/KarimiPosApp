using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IUnitOfWork _unit;

        public DepartmentController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody] DepartmentModel department)
        {
            return Ok(_unit.Department.Insert(department));
        }

        [HttpPut]
        public IActionResult Put([FromBody] DepartmentModel department)
        {
            return Ok(_unit.Department.Update(department));
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            return Ok(_unit.Department.Delete(new DepartmentModel { Id=id}));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.Department.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }


        [HttpGet("get")]
        public IActionResult Get(string text)
        {
            try
            {
                return Ok(_unit.Department.Get(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string text)
        {
            try
            {
                return Ok(_unit.Department.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
    }

}
