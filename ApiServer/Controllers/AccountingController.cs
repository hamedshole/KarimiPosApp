using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public AccountingController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public IActionResult PersonCreditList()
        {
            return Ok(_unit.Acounting.PersonCreditList());
        }
        [HttpGet("payouts/")]
        public IActionResult PayoutList([FromQuery] DateTime date)
        {
            return Ok(_unit.Acounting.PayoutList(date));
        }
    }
}
