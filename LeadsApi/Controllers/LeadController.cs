using LeadsApi.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LeadsApi.Controllers
{
    [Route("api/lead")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateLead(
            [FromServices]IMediator mediator,
            [FromBody]CreateLeadRequest request)
        {
            return Ok(mediator.Send(request).Result);
        }

        [HttpPatch]
        public void AcceptLead()
        {

        }

        [HttpGet("tab/invited")]
        public void GetInvited()
        {

        }

        [HttpGet("tab/accepted")]
        public void GetAccepted()
        {

        }
    }
}
