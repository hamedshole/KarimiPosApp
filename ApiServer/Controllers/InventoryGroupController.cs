using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryGroupController : ControllerBase
    {

        private readonly IUnitOfWork _unit;

        public InventoryGroupController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(_unit.InventoryGroup.Insert(inventoryGroup));
        }
        [HttpPut]
        public IActionResult Put([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(_unit.InventoryGroup.Update(inventoryGroup));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]InventoryGroupModel inventoryGroup)
        {
            return Ok(_unit.InventoryGroup.Delete(inventoryGroup));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.InventoryGroup.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("get")]
        public IActionResult Get([FromBody] string inventoryGroup)
        {
            try
            {
                return Ok(_unit.InventoryGroup.Get(inventoryGroup));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("search")]
        public IActionResult Search([FromBody] string text)
        {
            try
            {
                return Ok(_unit.InventoryGroup.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
