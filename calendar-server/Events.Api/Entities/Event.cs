using System;

// REQUIREMENT 4
namespace calendar_server.Entities
{
    /*
        record types are classes that have better support for immutable objects
        has with-expressions support
        value-based equality support
    */
    public record Event : IEquatable<Event>
    {
        // REQUIREMENT 11
        public Guid eventID { get; init; }
        public string name { get; init; }
        public string eventType { get; init; }
        public string address { get; init; }
        public DateTimeOffset startTime { get; init; }
        public DateTimeOffset endTime { get; init; }
        public string details { get; init; }

        public virtual bool Equals(Event anEvent)
        {
            return anEvent.eventID == this.eventID;
        }

        // REQUIREMENT 7
        // REQUIREMENT OPTIONAL 3
        public override int GetHashCode() => this.eventID.GetHashCode();
    }
}
