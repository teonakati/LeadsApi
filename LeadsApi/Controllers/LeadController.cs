using LeadsApi.Application.Commands;
using LeadsApi.Application.Queries;
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

        [HttpPatch("{id}")]
        public IActionResult AcceptLead([FromServices] IMediator mediator, int id)
        {
            return Ok(mediator.Send(new AcceptLeadRequest(id)).Result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeclineLead([FromServices] IMediator mediator, int id)
        {
            return Ok(mediator.Send(new DeclineLeadRequest(id)).Result);
        }

        [HttpGet("tab/invited")]
        public IActionResult GetInvited([FromServices] IMediator mediator)
        {
            return Ok(mediator.Send(new GetLeadInvited()).Result);
        }

        [HttpGet("tab/accepted")]
        public IActionResult GetAccepted([FromServices] IMediator mediator)
        {
            return Ok(mediator.Send(new GetLeadAccepted()).Result);

        }
    }
}
