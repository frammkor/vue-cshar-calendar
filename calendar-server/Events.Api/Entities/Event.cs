using System;

namespace calendar_server.Entities
{
    /*
        record types are classes that have better support for immutable objects
        has with-expressions support
        value-based equality support
    */
    public record Event
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
