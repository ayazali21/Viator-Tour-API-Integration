using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public class TravellerAgeBand
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("pluralDescription")]
        public string PluralDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ageBandId")]
        public long AgeBandId { get; set; }
    }
}
