using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {   

        private readonly IUnitOfWork _unit;

        public ItemController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ItemModel item)
        {
            return Ok(_unit.Item.Insert(item));
        }
        [HttpPut]
        public IActionResult Put([FromBody]ItemModel item)
        {
            return Ok(_unit.Item.Update(item));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]ItemModel item)
        {
            return Ok(_unit.Item.Delete(item));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //try
            //{
            return Ok(_unit.Item.List());
            //}
            //catch (Exception e)
            //{

            //    return Ok(e.Message + e.StackTrace);
            //}

        }
        [HttpPost("get")]
        public IActionResult Get([FromBody] string item)
        {
            try
            {
                return Ok(_unit.Item.Get(item));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("search")]
        public IActionResult Search([FromBody] string text)
        {
            try
            {
                return Ok(_unit.Item.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

        [HttpPost("FilterByDepartment")]
        public IActionResult FilterByDepartment([FromBody] string item)
        {
            try
            {
                return Ok(_unit.Item.FilterByDepartment(item));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }
        }
        [HttpPost("SearchFilterByDepartment")]
        public IActionResult SearchFilterByDepartment([FromBody] ItemModel item)
        {
            try
            {
                return Ok(_unit.Item.SearchFilterByDepartment(item));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }
        }

        [HttpPost("GetByBarcode")]
        public IActionResult GetByBarcode([FromBody] string barcode)
        {
            try
            {
                return Ok(_unit.Item.GetByBarcode(barcode));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
