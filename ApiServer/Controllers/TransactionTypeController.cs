using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionTypeController:ControllerBase
    {
        private  readonly IUnitOfWork _unit;

        public TransactionTypeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TransactionTypeModel transactionType)
        {
            return Ok(_unit.TransactionType.Insert(transactionType));
        }
        [HttpPut]
        public IActionResult Put([FromBody]TransactionTypeModel transactionType)
        {
            return Ok(_unit.TransactionType.Update(transactionType));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]TransactionTypeModel transactionType)
        {
            return Ok(_unit.TransactionType.Delete(transactionType));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(_unit.TransactionType.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.TransactionType.List());
        }
        [HttpPost("Search")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(_unit.TransactionType.Search(text));
        }
    }
}
