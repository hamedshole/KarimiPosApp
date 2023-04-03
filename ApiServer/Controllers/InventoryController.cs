using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private readonly IUnitOfWork _unit;

        public InventoryController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]InventoryModel inventory)
        {
            return Ok(_unit.Inventory.Insert(inventory));
        }
        [HttpPut]
        public IActionResult Put([FromBody]InventoryModel inventory)
        {
            return Ok(_unit.Inventory.Update(inventory));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]InventoryModel inventory)
        {
            return Ok(_unit.Inventory.Delete(inventory));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.Inventory.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("get")]
        public IActionResult Get([FromQuery] string text)
        {
            try
            {
                return Ok(_unit.Inventory.Get(text));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("search")]
        public IActionResult Search([FromQuery] string text)
        {
            try
            {
                return Ok(_unit.Inventory.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
