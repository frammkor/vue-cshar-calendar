using System.Collections.Generic;
using calendar_server.Entities;
using System;

namespace calendar_server.Repositories
{
    public interface IEventsRepository
    {
        Event GetEvent(Guid id);
        IEnumerable<Event> GetEvents();
    }
}