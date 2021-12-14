using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using calendar_server.Entities;
using calendar_server.Dtos;
using calendar_server.Repositories;
using System.Linq;

namespace calendar_server.Controllers
{
    // GET /events
    [ApiController]
    [Route("[controller]")] // [Route("[events]")]
    // REQUIREMENT 3
    public class EventsController : ControllerBase // REQUIREMENT 14
    {
        private readonly IEventsRepository repository;

        // REQUIREMENT 6: an example of Dependency Inversion / Injection
        public EventsController(IEventsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EventDto>> GetEvents()
        {
            // REQUIREMENT 9
            try
            {
                return (ActionResult)repository.GetEvents().Select(e => e.AsDto());
            }
            catch (System.Exception)
            {
                return NotFound(); // TODO change it to a different error
            }
            
        }
        

        // GET /events/{id}
        [HttpGet("{id}")]
        public ActionResult<Event> GetEvent(Guid id)
        {
            Event anEvent = repository.GetEvent(id);

            if (anEvent is null)
            {
                return NotFound();
            }

            return anEvent;
        }
    }
}
