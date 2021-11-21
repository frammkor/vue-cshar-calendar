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

        // GET /events
        [HttpGet]
        public IEnumerable<Event> GetEvents()
        // public IEnumerable<EventDto> GetEvents()
        {

            // var events = repository.GetEvents().Select(event => new EventDto {
            //     eventID = Event.eventID,
            //     name = Event.name,
            //     eventType = Event.eventType,
            //     address = Event.address,
            //     startTime = Event.startTime,
            //     endTime = Event.endTime,
            //     details = Event.details,
            // });
            var events = repository.GetEvents();

            return events;
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
