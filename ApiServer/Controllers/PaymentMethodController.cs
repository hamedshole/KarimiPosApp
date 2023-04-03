using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController:ControllerBase
    {
       private readonly IUnitOfWork _unit;

        public PaymentMethodController(IUnitOfWork unit)
        {
            _unit= unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this._unit.PaymentMethod.Insert(paymentMethod));
        }
        [HttpPut]
        public IActionResult Put([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this._unit.PaymentMethod.Update(paymentMethod));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PaymentMethodModel paymentMethod)
        {
            return Ok(this._unit.PaymentMethod.Delete(paymentMethod));
        }
        [HttpPost("get")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(this._unit.PaymentMethod.Get(text));
        }
        [HttpPost("search")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(this._unit.PaymentMethod.Search(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.PaymentMethod.List());
        }
    }
}
