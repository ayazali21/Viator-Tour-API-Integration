using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial  class BookingAvaialbilityDates : CommonResponse
    {
        [JsonProperty("data")]
        public Dictionary<string, List<string>> AvailableDates { get; set; }
    }

    public partial class BookingAvaialbilityDates
    {
        public static BookingAvaialbilityDates FromJson(string json) => JsonConvert.DeserializeObject<BookingAvaialbilityDates>(json, Converter.Settings);
    }

}
