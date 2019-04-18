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
        public object StartDate { get; set; }

        [JsonProperty("endDate")]
        public object EndDate { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public override string ToString()
        {
            return $"{this.EventName} { this.Description} { this.StartDate} { this.EndDate}";
        }
    }
}
