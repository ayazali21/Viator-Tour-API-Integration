using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class BookingAvailableTourGrade : CommonResponse
    {
        [JsonProperty("data")]
        public List<TourGrades> TourGrades { get; set; }

    }

    public  class TourGrades
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("bookingDate")]
        public DateTimeOffset BookingDate { get; set; }

        [JsonProperty("ageBands")]
        public List<BookingAgeBand> AgeBands { get; set; }

        [JsonProperty("ageBandsRequired")]
        public List<List<AgeBandsRequired>> AgeBandsRequired { get; set; }

        [JsonProperty("langServices")]
        public LangServices LangServices { get; set; }

        [JsonProperty("gradeCode")]
        public string GradeCode { get; set; }

        [JsonProperty("unavailableReason")]
        public string UnavailableReason { get; set; }

        [JsonProperty("gradeTitle")]
        public string GradeTitle { get; set; }

        [JsonProperty("gradeDepartureTime")]
        public string GradeDepartureTime { get; set; }

        [JsonProperty("gradeDescription")]
        public string GradeDescription { get; set; }

        [JsonProperty("defaultLanguageCode")]
        public string DefaultLanguageCode { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("retailPrice")]
        public double RetailPrice { get; set; }

        [JsonProperty("retailPriceFormatted")]
        public string RetailPriceFormatted { get; set; }

        [JsonProperty("merchantNetPrice")]
        public double MerchantNetPrice { get; set; }

        [JsonProperty("merchantNetPriceFormatted")]
        public string MerchantNetPriceFormatted { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public  class BookingAgeBand
    {
        [JsonProperty("bandId")]
        public long BandId { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("bandTotal")]
        public double BandTotal { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("bandTotalFormatted")]
        public string BandTotalFormatted { get; set; }

        [JsonProperty("pricePerTraveler")]
        public double PricePerTraveler { get; set; }

        [JsonProperty("pricePerTravelerFormatted")]
        public string PricePerTravelerFormatted { get; set; }
    }

    public partial class AgeBandsRequired
    {
        [JsonProperty("bandId")]
        public long BandId { get; set; }

        [JsonProperty("minimumCountRequired")]
        public long MinimumCountRequired { get; set; }

        [JsonProperty("maximumCountRequired")]
        public long? MaximumCountRequired { get; set; }
    }
    public partial class BookingAvailableTourGrade
    {
        public static BookingAvailableTourGrade FromJson(string json) => JsonConvert.DeserializeObject<BookingAvailableTourGrade>(json, CommonConverter.Settings);
    }
}
