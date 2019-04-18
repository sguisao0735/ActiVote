namespace ActiVote.Web.Controllers.API
{
    using ActiVote.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[Controller]")]
    public class EventsController : Controller
    {
        private readonly IEventRepository eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(this.eventRepository.GetAllWithUsers());
        }
    }
}
