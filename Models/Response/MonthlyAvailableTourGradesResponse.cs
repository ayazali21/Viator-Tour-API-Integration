using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class MonthlyAvailableTourGrades : CommonResponse
    {
      
        [JsonProperty("data")]
        public MonthlyAvailableTour MonthlyAvailableTour { get; set; }

    }
    public partial class MonthlyAvailableTourGrades
    {
        public static MonthlyAvailableTourGrades FromJson(string json) => JsonConvert.DeserializeObject<MonthlyAvailableTourGrades>(json, Converter.Settings);
    }
    public  class MonthlyAvailableTour
    {
        [JsonProperty("bookingMonth")]
        public string BookingMonth { get; set; }

        [JsonProperty("pricingUnit")]
        public string PricingUnit { get; set; }

        [JsonProperty("dates")]
        public List<Date> Dates { get; set; }
    }

    public  class Date
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("bookingDate")]
        public DateTimeOffset BookingDate { get; set; }

        [JsonProperty("tourGrades")]
        public List<TourGradeInfo> TourGrades { get; set; }

        [JsonProperty("callForLastMinAvailability")]
        public bool CallForLastMinAvailability { get; set; }
    }

    public  class TourGradeInfo
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("gradeCode")]
        public string GradeCode { get; set; }

        [JsonProperty("gradeTitle")]
        public string GradeTitle { get; set; }

        [JsonProperty("pricingMatrix")]
        public List<PricingMatrix> PricingMatrix { get; set; }
    }

    public  class PricingMatrix
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("pricingUnit")]
        public string PricingUnit { get; set; }

        [JsonProperty("bookingDate")]
        public DateTimeOffset BookingDate { get; set; }

        [JsonProperty("ageBandPrices")]
        public List<AgeBandPrice> AgeBandPrices { get; set; }
    }

    public  class AgeBandPrice
    {
        [JsonProperty("bandId")]
        public long BandId { get; set; }

        [JsonProperty("prices")]
        public List<PriceList> Prices { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("minimumCountRequired")]
        public long MinimumCountRequired { get; set; }

        [JsonProperty("maximumCountRequired")]
        public long? MaximumCountRequired { get; set; }
    }

    public  class PriceList
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("minNoOfTravellersRequiredForPrice")]
        public long MinNoOfTravellersRequiredForPrice { get; set; }

        [JsonProperty("priceFormatted")]
        public string PriceFormatted { get; set; }

        [JsonProperty("merchantNetPrice")]
        public double MerchantNetPrice { get; set; }

        [JsonProperty("merchantNetPriceFormatted")]
        public string MerchantNetPriceFormatted { get; set; }
    }
}
