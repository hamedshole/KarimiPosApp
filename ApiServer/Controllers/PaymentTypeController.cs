using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController:ControllerBase
    {
      private readonly  IUnitOfWork _unit;

        public PaymentTypeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this._unit.PaymentType.Insert(paymentType));
        }
        [HttpPut]
        public IActionResult Put([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this._unit.PaymentType.Update(paymentType));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PaymentTypeModel paymentType)
        {
            return Ok(this._unit.PaymentType.Delete(paymentType));
        }
        [HttpPost("get")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(this._unit.PaymentType.Get(text));
        }
        [HttpPost("search")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(this._unit.PaymentType.Search(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.PaymentType.List());
        }
    }
}
