using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public TransactionController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet("[Action]")]
        public IActionResult LastCode()
        {
            return Ok(this._unit.Transaction.LastCode());
        }
        [HttpPost]
        public IActionResult Post([FromBody]TransactionModel model)
        {
            return Ok(_unit.Transaction.Insert(model));
        }

        [HttpGet("[Action]")]
        public IActionResult LastValue()
        {
            return Ok(_unit.Transaction.LastValue());
        }

    }
}
