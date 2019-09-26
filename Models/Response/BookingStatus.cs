using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public class BookingStatus
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        [JsonProperty("amended")]
        public bool Amended { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("failed")]
        public bool Failed { get; set; }
    }
}
