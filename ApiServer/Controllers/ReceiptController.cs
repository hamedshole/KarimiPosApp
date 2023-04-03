using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public ReceiptController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ReceiptModel receipt)
        {
            return Ok(_unit.Receipt.Insert(receipt));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string barcode)
        {
            try
            {


                return Ok( _unit.Receipt.Get(barcode));
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
           
        }
        [HttpPost("[Action]")]
        public IActionResult List([FromBody]WorkstationReceiptFilterModel workstationReceiptFilter)
        {
            return Ok(_unit.Receipt.List(workstationReceiptFilter));
        }
        [HttpGet("[Action]")]
        public IActionResult CashierList()
        {
            return Ok(_unit.Receipt.CashierList());
        }
        [HttpPost("[Action]")]
        public IActionResult GetTransaction([FromBody]TransactionModel transaction)
        {
            return Ok(this._unit.Receipt.GetTransaction(transaction.Id));
        }
    }
}
