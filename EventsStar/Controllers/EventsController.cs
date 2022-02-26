using EventsStar.Application.Contracts.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventsStar.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventsController : ControllerBase
    {
        private IEventAppService EventAppService { get; }
        public EventsController(IEventAppService eventAppService)
        {
            EventAppService = eventAppService;
        }

        [HttpGet]
        [AllowAnonymous ]
        public async Task<ActionResult<EventDto>> Get(Guid id)
        {
            return Ok(await EventAppService.GetAsync(id));
        }

    }
}
