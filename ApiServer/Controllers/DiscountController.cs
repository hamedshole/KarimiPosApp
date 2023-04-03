using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController:ControllerBase
    {
        private IUnitOfWork _unit;

        public DiscountController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpPost]
        public IActionResult Post([FromBody]DiscountModel discount)
        {
            return Ok( this._unit.Discount.Insert(discount));
        }
        [HttpPut]
        public IActionResult Put([FromBody]DiscountModel discount)
        {
            return Ok(this._unit.Discount.Update(discount));
        }
        [HttpDelete]
        public  IActionResult Delete([FromBody]DiscountModel discount)
        {
            return Ok(this._unit.Discount.Delete(discount));
        }
        [HttpGet("get")]
        public IActionResult Get([FromBody]string title)
        {
            return Ok( this._unit.Discount.Get(title));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.Discount.List());
        }
        [HttpGet("search")]
        public IActionResult Search(string text)
        {
            return Ok(this._unit.Discount.Search(text));
        }
    }
}
