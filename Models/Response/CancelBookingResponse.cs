using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class CancelBookingResponse : CommonResponse
    {
        [JsonProperty("data")]
        public CancelInformation CancelInformation { get; set; }
    }
    public  class CancelInformation
    {
        [JsonProperty("itineraryId")]
        public string ItineraryId { get; set; }

        [JsonProperty("cancelItems")]
        public List<CancelItem> CancelItems { get; set; }

        [JsonProperty("distributorRef")]
        public string DistributorRef { get; set; }
    }

    public  class CancelItem
    {
        [JsonProperty("cancellationResponseStatusCode")]
        public string CancellationResponseStatusCode { get; set; }

        [JsonProperty("cancellationResponseDescription")]
        public string CancellationResponseDescription { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("distributorItemRef")]
        public string DistributorItemRef { get; set; }
    }

    public partial class CancelBookingResponse
    {
        public static CancelBookingResponse FromJson(string json) => JsonConvert.DeserializeObject<CancelBookingResponse>(json, Converter.Settings);
    }


    

}
