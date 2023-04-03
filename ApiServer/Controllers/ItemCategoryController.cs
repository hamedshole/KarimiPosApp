using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        readonly IUnitOfWork _unit;

        public ItemCategoryController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(_unit.ItemCategory.Insert(itemCategory));
        }
        [HttpPut]
        public IActionResult Put([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(_unit.ItemCategory.Update(itemCategory));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]ItemCategoryModel itemCategory)
        {
            return Ok(_unit.ItemCategory.Delete(itemCategory));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.ItemCategory.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("get")]
        public IActionResult Get([FromBody] string itemCategory)
        {
            try
            {
                return Ok(_unit.ItemCategory.Get(itemCategory));
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
                return Ok(_unit.ItemCategory.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
    }
}
