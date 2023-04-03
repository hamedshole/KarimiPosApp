using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierCompanyController:ControllerBase
    {
        private  readonly IUnitOfWork _unit;

        public SupplierCompanyController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok( this._unit.SupplierCompany.Insert(supplierCompany));
        }
        [HttpPut]
        public IActionResult Put([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok(this._unit.SupplierCompany.Update(supplierCompany));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]SupplierCompanyModel supplierCompany)
        {
            return Ok(this._unit.SupplierCompany.Delete(supplierCompany));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(this._unit.SupplierCompany.Get(text));
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(this._unit.SupplierCompany.Search(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._unit.SupplierCompany.List());
        }
    }
}
