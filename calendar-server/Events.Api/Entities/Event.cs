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
        public string threadEventID { get; init; }
        public string parentEventID { get; init; }
        public string rootEventID { get; init; }
        public string name { get; init; }
        public string name_en { get; init; }
        public string eventType { get; init; }
        public string genre { get; init; }
        public string attendanceMode { get; init; }
        public string addressID { get; init; }
        public string undiscloseAdressFlag { get; init; }
        public DateTimeOffset startTime { get; init; }
        public DateTimeOffset endTime { get; init; }
        public decimal price { get; init; }
        public string currency { get; init; }
        public decimal priceUSD { get; init; }
        public string details { get; init; }
        public string details_en { get; init; }
        public string videoEmbeddedCode { get; init; }
        public string eventCancelledFlag { get; init; }
        public string organizersName { get; init; }
        public string purchaseUrl { get; init; }
    }
}
