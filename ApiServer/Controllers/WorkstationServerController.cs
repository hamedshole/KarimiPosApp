using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace KarimiApp.Server.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkstationServerController : ControllerBase
    {
        private readonly IWorkstationAccess _workstationAccess;

        public WorkstationServerController(IWorkstationAccess workstationAccess)
        {
            _workstationAccess = workstationAccess;
        }
        [HttpPost("[Action]")]
        public IActionResult SendMessage([FromBody]WorkStationMessageModel workStationMessage)
        {
            return Ok(this._workstationAccess.SendMessage(workStationMessage));
        }
        [HttpPost("[Action]")]
        public IActionResult SendPlu([FromBody]WorkstationPluModel workstationPlu)
        {
            try
            {
                return Ok( this._workstationAccess.SendPlu(workstationPlu));
            }
            catch (System.Exception e)
            {

                return Ok(e.Message);
            }
           
        }
        [HttpPost("[Action]")]
        public IActionResult SendHardKey([FromBody] WorkstationHardKeyModel workstationHardKey)
        {
            return Ok(this._workstationAccess.SendHardKey(workstationHardKey));
        }

       

    
    }
}
