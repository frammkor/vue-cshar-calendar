using Microsoft.AspNetCore.Mvc;
using calendar_server.Repositories;
using System.Collections.Generic;
using calendar_server.Entities;


namespace calendar_server.Controllers
{
    // GET /events
    [ApiController]
    [Route("[controller]")] // [Route("[events]")]
    public class EventsController : ControllerBase
    {
        private readonly InMemEventsRepository repository;

        public EventsController()
        {
            repository = new InMemEventsRepository();
        }

        [HttpGet]
        public IEnumerable<Event> GetEvents()
        {
            return repository.GetEvents();
        }
    }
}