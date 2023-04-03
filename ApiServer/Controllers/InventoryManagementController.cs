using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryManagementController:ControllerBase
    {
        IUnitOfWork _unit;

        public InventoryManagementController(IUnitOfWork unitOfWork)
        {
            this._unit = unitOfWork;
        }

        [HttpPost]
        public IActionResult AddItem([FromBody]InventoryLogModel item)
        {
            try
            {
                return Ok(this._unit.InventoryManagement.AddItem(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpPost("getitemlog")]
        public IActionResult GetItemLog([FromBody]ItemModel item)
        {
            try
            {
                return Ok(this._unit.InventoryManagement.GetItemLog(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpPost("getitemstock")]
        public IActionResult GetItemStock([FromBody] ItemModel item)
        {
            try
            {
                return Ok(this._unit.InventoryManagement.GetItemStock(item));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
