using System.Collections.Generic;
using calendar_server.Entities;
using System.Linq;
using System;

namespace calendar_server.Repositories
{
    // REQUIREMENT 1
    public class InMemEventsRepository : IEventsRepository
    {
        // REQUIREMENT 15 A
        private readonly List<Event> events = new()
        {
            new Event
            {
                eventID = Guid.NewGuid(),
                name = "test Event  1",
            },
            new Event
            {
                eventID = Guid.NewGuid(),
                name = "test Event  2",
            },
            new Event
            {
                eventID = Guid.NewGuid(),
                name = "test Event  3",
            }
        };

        // REQUIREMENT 15 B
        public IEnumerable<Event> GetEvents()
        {
            return events;
        }

        public Event GetEvent(Guid id)
        {
            // Func<Event, bool> compare = (e) => e.eventID == id;
            return events.Where(aEvent => aEvent.eventID == id).SingleOrDefault(); ;
        }
    }
}
