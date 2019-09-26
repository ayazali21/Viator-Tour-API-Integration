using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class CalculatedBookingPriceResponse : CommonResponse
    {
        [JsonProperty("data")]
        public BookingPrice BookingPrice { get; set; }
    }
    public  class BookingPrice
    {
        [JsonProperty("rulesApplied")]
        public object RulesApplied { get; set; }

        [JsonProperty("promoCode")]
        public string PromoCode { get; set; }

        [JsonProperty("itinerary")]
        public Itinerary Itinerary { get; set; }

        [JsonProperty("paymentGatewayInfo")]
        public object PaymentGatewayInfo { get; set; }

        [JsonProperty("promoCodeValid")]
        public bool PromoCodeValid { get; set; }

        [JsonProperty("promoCodeExpired")]
        public bool PromoCodeExpired { get; set; }

        [JsonProperty("itineraryFromPrice")]
        public double ItineraryFromPrice { get; set; }

        [JsonProperty("itineraryFromPriceFormatted")]
        public string ItineraryFromPriceFormatted { get; set; }

        [JsonProperty("itineraryNewPrice")]
        public double ItineraryNewPrice { get; set; }

        [JsonProperty("itineraryNewPriceFormatted")]
        public string ItineraryNewPriceFormatted { get; set; }

        [JsonProperty("itinerarySaving")]
        public long ItinerarySaving { get; set; }

        [JsonProperty("itinerarySavingFormatted")]
        public string ItinerarySavingFormatted { get; set; }

        [JsonProperty("hasPromoCode")]
        public bool HasPromoCode { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }

    public  class Itinerary
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
        public object VoucherUrl { get; set; }

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
        public object BookerEmail { get; set; }

        [JsonProperty("distributorRef")]
        public object DistributorRef { get; set; }

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

    public partial class CalculatedBookingPriceResponse
    {
        public static CalculatedBookingPriceResponse FromJson(string json) => JsonConvert.DeserializeObject<CalculatedBookingPriceResponse>(json, CommonConverter.Settings);
    }

}
