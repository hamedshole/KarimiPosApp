using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public SupplierController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]SupplierAgentModel supplier)
        {
            return Ok(_unit.Supplier.Insert(supplier));
        }
        [HttpPut]
        public IActionResult Put([FromBody]SupplierAgentModel supplier)
        {
            return Ok(_unit.Supplier.Update(supplier));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]SupplierAgentModel supplier)
        {
            return Ok(_unit.Supplier.Delete(supplier));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody] string text)
        {
            return Ok(_unit.Supplier.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Supplier.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(_unit.Supplier.Search(text));
        }
    }
}
