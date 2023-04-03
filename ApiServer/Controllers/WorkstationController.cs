using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkstationController:ControllerBase
    {
        private  readonly IUnitOfWork _unit;

        public WorkstationController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody] WorkstationModel workstation)
        {
            return Ok(this._unit.Workstation.Insert(workstation));
        }
        [HttpPut]
        public IActionResult Put([FromBody] WorkstationModel workstation)
        {
            return Ok(this._unit.Workstation.Update(workstation));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] WorkstationModel workstation)
        {
            return Ok(this._unit.Workstation.Delete(workstation));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody] string workstation)
        {
            return Ok(this._unit.Workstation.Get(workstation));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.Workstation.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(this._unit.Workstation.Search(text));
        }
        [HttpPost("[Action]")]
        public IActionResult TotalReceiptAmount([FromBody]string workstation)
        {
            return Ok(this._unit.Workstation.TotalReceiptAmount(workstation));
        }
        [HttpPost("[Action]")]
        public IActionResult TotalReceiptAmountForDate([FromBody] ReceiptModel receipt)
        {
            return Ok(this._unit.Workstation.TotalReceiptAmountForDate(receipt));
        }
        [HttpPost("[Action]")]
        public IActionResult TotalReceiptCount([FromBody]string workstation)
        {
            return Ok(this._unit.Workstation.TotalReceiptCount(workstation));
        }
        [HttpPost("[Action]")]
        public IActionResult TotalReceiptCountForDate([FromBody]ReceiptModel receipt)
        {
            return Ok(this._unit.Workstation.TotalReceiptCountForDate(receipt));
        }

    }
}
