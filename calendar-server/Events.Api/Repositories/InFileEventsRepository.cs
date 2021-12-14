using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using calendar_server.Entities;

namespace calendar_server.Repositories
{
    // REQUIREMENT 2
    public class InFileEventsRepository : IEventsRepository // , IEnumerable<Event>
    {
        private readonly List<Event> events = new() {};

        public InFileEventsRepository()
        {
            events = GetEventsFromFile(Path.Combine(Directory.GetCurrentDirectory(), "Repositories/EventsRecord.json"));
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
        private List<Event> GetEventsFromFile(string filePathName)
        {
            // REQUIREMENT 9
            try
            {
                using (StreamReader r = new StreamReader(filePathName)) // REQUIREMENT OPTIONAL 1
                {
                    string json = r.ReadToEnd();
                    List<Event> items = JsonConvert.DeserializeObject<List<Event>>(json);
                    return items;
                } 
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                return new List<Event>() {};
            }
        }
    }
}
