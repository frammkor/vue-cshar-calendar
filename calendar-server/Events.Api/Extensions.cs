using calendar_server.Dtos;
using calendar_server.Entities;

namespace calendar_server
{
    public static class Extensions
    {
        public static EventDto AsDto(this Event e)
        {
            return new EventDto {
                eventID = e.eventID,
                name = e.name,
                eventType = e.eventType,
                address = e.address,
                startTime = e.startTime,
                endTime = e.endTime,
                details = e.details,
            };
        }
    }
}
