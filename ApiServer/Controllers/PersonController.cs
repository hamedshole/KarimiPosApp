using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController:ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Post([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Insert(person));
        }
        [HttpPut]
        public IActionResult Put([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Update(person));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PersonModel person)
        {
            return Ok(unitOfWork.Person.Delete(person));
        }
        [HttpPost("get")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(unitOfWork.Person.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(unitOfWork.Person.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(unitOfWork.Person.Search(text));
        }
        [HttpPost("[Action]")]
        public IActionResult Settle([FromBody] PersonModel person)
        {
            return Ok(unitOfWork.Person.Settle(person));
        }
    }
}
