using Shared.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KarimiApp.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosInfoController:ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public PosInfoController(IUnitOfWork unitOfWork)
        {
            _unit =unitOfWork;
        }
        [HttpPost]
        public IActionResult Post([FromBody]PosInfoModel posInfo)
        {
            return Ok(_unit.PosInfo.Insert(posInfo));
        }
        [HttpPut]
        public IActionResult Put([FromBody]PosInfoModel posInfo)
        {
            return Ok(_unit.PosInfo.Update(posInfo));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]PosInfoModel posInfo)
        {
            return Ok(_unit.PosInfo.Delete(posInfo));
        }
        [HttpPost("[Action]")]
        public IActionResult Get([FromBody]string text)
        {
            return Ok(_unit.PosInfo.Get(text));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.PosInfo.List());
        }
        [HttpPost("[Action]")]
        public IActionResult Search([FromBody]string text)
        {
            return Ok(_unit.PosInfo.Search(text));
        }
    }
}
