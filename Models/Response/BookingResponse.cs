using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class BookingResponse : CommonResponse
    {
        [JsonProperty("data")]
        public BookingDetail BookingDetail { get; set; }

    }
    public partial class BookingDetail
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("rulesApplied")]
        public object RulesApplied { get; set; }

        [JsonProperty("omniPreRuleList")]
        public object OmniPreRuleList { get; set; }

        [JsonProperty("bookingStatus")]
        public BookingStatus BookingStatus { get; set; }

        [JsonProperty("itemSummaries")]
        public List<ItemSummary> ItemSummaries { get; set; }

        [JsonProperty("voucherURL")]
        public string VoucherUrl { get; set; }

        [JsonProperty("securityToken")]
        public string SecurityToken { get; set; }

        [JsonProperty("paypalRedirectURL")]
        public object PaypalRedirectUrl { get; set; }

        [JsonProperty("userId")]
        public object UserId { get; set; }

        [JsonProperty("itineraryId")]
        public long ItineraryId { get; set; }

        [JsonProperty("exchangeRate")]
        public long ExchangeRate { get; set; }

        [JsonProperty("bookingDate")]
        public DateTimeOffset BookingDate { get; set; }

        [JsonProperty("voucherKey")]
        public string VoucherKey { get; set; }

        [JsonProperty("bookerEmail")]
        public string BookerEmail { get; set; }

        [JsonProperty("distributorRef")]
        public string DistributorRef { get; set; }

        [JsonProperty("totalPrice")]
        public double TotalPrice { get; set; }

        [JsonProperty("totalPriceFormatted")]
        public string TotalPriceFormatted { get; set; }

        [JsonProperty("totalPriceUSD")]
        public double TotalPriceUsd { get; set; }

        [JsonProperty("hasVoucher")]
        public bool HasVoucher { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
    public partial class BookingResponse
    {
        public static BookingResponse FromJson(string json) => JsonConvert.DeserializeObject<BookingResponse>(json, Converter.Settings);
    }

}
