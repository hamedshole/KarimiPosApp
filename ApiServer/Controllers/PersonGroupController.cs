using Shared.Model;
using Domain.Interfaces;
using System;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonGroupController : ControllerBase
    {

       private readonly IUnitOfWork _unit;

        public PersonGroupController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PersonGroupModel personGroup)
        {
            return Ok(_unit.PersonGroup.Insert(personGroup));
        }
        [HttpPut]
        public IActionResult Put([FromBody]PersonGroupModel personGroup)
        {
            return Ok(_unit.PersonGroup.Update(personGroup));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PersonGroupModel personGroup)
        {
            return Ok(_unit.PersonGroup.Delete(personGroup));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_unit.PersonGroup.List());
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody] string personGroup)
        {
            try
            {
                return Ok(_unit.PersonGroup.Get(personGroup));
            }
            catch (Exception e)
            {
                return Ok(e.Message + e.StackTrace);
            }

        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody] string text)
        {
            try
            {
                return Ok(_unit.PersonGroup.Search(text));
            }
            catch (Exception e)
            {

                return Ok(e.Message + e.StackTrace);
            }

        }

    }
}
