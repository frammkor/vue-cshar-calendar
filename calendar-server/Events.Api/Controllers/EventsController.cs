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
    public class EventsController : ControllerBase
    {
        private readonly IEventsRepository repository;

        public EventsController(IEventsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<EventDto> GetEvents()
        {
            return repository.GetEvents().Select(e => e.AsDto());
        }
        

        // GET /events/id
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
