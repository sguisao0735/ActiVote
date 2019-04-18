namespace ActiVote.Common.Models
{
    using System;
    using Newtonsoft.Json;
    
    public class Event
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("eventName")]
        public string EventName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
