using System;

namespace calendar_server.Dtos
{
    // i mean like what is this? how AM I SUPPOSED TO UNDERSATND
    public record EventDto
    {
        public Guid eventID { get; init; }
        public string name { get; init; }
        public string eventType { get; init; }
        public string address { get; init; }
        public DateTimeOffset startTime { get; init; }
        public DateTimeOffset endTime { get; init; }
        public string details { get; init; }
    }
}