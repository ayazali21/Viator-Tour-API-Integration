using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class BookingStatusResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<Result> BookingStatusDetail { get; set; }
    }
    public  class Result
    {
        [JsonProperty("itineraryId")]
        public long ItineraryId { get; set; }

        [JsonProperty("bookingStatus")]
        public BookingStatus BookingStatus { get; set; }

        [JsonProperty("bookingDate")]
        public DateTimeOffset BookingDate { get; set; }

        [JsonProperty("distributorRef")]
        public string DistributorRef { get; set; }

        [JsonProperty("itemSummaries")]
        public List<ItemSummary> ItemSummaries { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
    }

    public partial class BookingStatusResponse
    {
        public static BookingStatusResponse FromJson(string json) => JsonConvert.DeserializeObject<BookingStatusResponse>(json, Converter.Settings);
    }
}
