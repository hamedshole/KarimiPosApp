using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTransactionController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public PaymentTransactionController(IUnitOfWork unit)
        {
            _unit= unit;
        }

        [HttpPost]
        public IActionResult Post ([FromBody]PaymentTransactionModel model)
        {
            return Ok(_unit.PaymentTransaction.Insert(model));
        }
    }
}
