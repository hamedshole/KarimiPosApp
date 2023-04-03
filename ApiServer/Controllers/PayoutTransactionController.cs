using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayoutTransactionController:ControllerBase
    {
      private readonly  IUnitOfWork unitOfWork;

        public PayoutTransactionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PayoutTransactionModel model)
        {
            return Ok(unitOfWork.PayoutTransaction.Insert(model));
        }
        [HttpPost("get")]
        public IActionResult GetAll([FromBody] PayoutTransactionModel payoutTransaction)
        {
            var res = unitOfWork.PayoutTransaction.Read(payoutTransaction);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PayoutTransactionModel payoutTransaction)
        {
            return Ok(unitOfWork.PayoutTransaction.Delete(payoutTransaction));
        }
    }
}
