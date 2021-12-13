using System.Collections.Generic;
using calendar_server.Entities;
using System.Linq;
using System;

namespace calendar_server.Repositories
{
    public class InFileEventsRepository : IEventsRepository // , IEnumerable<Event>
    {
        private readonly List<Event> events = new() {};

        public InFileEventsRepository()
        {
            events = GetEventsFromFile();
        }

        public IEnumerable<Event> GetEvents()
        {
            return events;
        }

        public Event GetEvent(Guid id)
        {
            // Func<Event, bool> compare = (e) => e.eventID == id;
            return events.Where(aEvent => aEvent.eventID == id).SingleOrDefault(); ;
        }

        private List<Event> GetEventsFromFile()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            } 
        }
    }
}
