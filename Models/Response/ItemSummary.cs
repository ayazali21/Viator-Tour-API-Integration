using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public class ItemSummary
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("rulesApplied")]
        public object RulesApplied { get; set; }

        [JsonProperty("bookingStatus")]
        public BookingStatus BookingStatus { get; set; }

        [JsonProperty("travellerAgeBands")]
        public List<TravellerAgeBand> TravellerAgeBands { get; set; }

        [JsonProperty("voucherKey")]
        public string VoucherKey { get; set; }

        [JsonProperty("voucherURL")]
        public string VoucherUrl { get; set; }

        [JsonProperty("voucherRequirements")]
        public string VoucherRequirements { get; set; }

        [JsonProperty("productPulledDown")]
        public bool ProductPulledDown { get; set; }

        [JsonProperty("merchantCancellable")]
        public bool MerchantCancellable { get; set; }

        [JsonProperty("productWidgetList")]
        public object ProductWidgetList { get; set; }

        [JsonProperty("savingAmount")]
        public long SavingAmount { get; set; }

        [JsonProperty("applePassSupported")]
        public bool ApplePassSupported { get; set; }

        [JsonProperty("supplierName")]
        public string SupplierName { get; set; }

        [JsonProperty("supplierPhoneNumber")]
        public string SupplierPhoneNumber { get; set; }

        [JsonProperty("vouchers")]
        public object Vouchers { get; set; }

        [JsonProperty("passbooks")]
        public object Passbooks { get; set; }

        [JsonProperty("termsAndConditions")]
        public string TermsAndConditions { get; set; }

        [JsonProperty("lastRetailPriceFormatted")]
        public string LastRetailPriceFormatted { get; set; }

        [JsonProperty("departsFrom")]
        public string DepartsFrom { get; set; }

        [JsonProperty("pickupHotelId")]
        public object PickupHotelId { get; set; }

        [JsonProperty("pickupHotelName")]
        public object PickupHotelName { get; set; }

        [JsonProperty("hoursConfirmed")]
        public long HoursConfirmed { get; set; }

        [JsonProperty("priceUSD")]
        public double PriceUsd { get; set; }

        [JsonProperty("itineraryId")]
        public long ItineraryId { get; set; }

        [JsonProperty("tourGradeCode")]
        public string TourGradeCode { get; set; }

        [JsonProperty("distributorItemRef")]
        public string DistributorItemRef { get; set; }

        [JsonProperty("languageServicesLanguageCode")]
        public string LanguageServicesLanguageCode { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("travelDate")]
        public DateTimeOffset TravelDate { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("leadTravellerSurname")]
        public string LeadTravellerSurname { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("destId")]
        public long DestId { get; set; }

        [JsonProperty("voucherOption")]
        public string VoucherOption { get; set; }

        [JsonProperty("itemId")]
        public long ItemId { get; set; }

        [JsonProperty("priceFormatted")]
        public string PriceFormatted { get; set; }

        [JsonProperty("barcodeOption")]
        public string BarcodeOption { get; set; }

        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }

        [JsonProperty("departurePoint")]
        public string DeparturePoint { get; set; }

        [JsonProperty("departurePointAddress")]
        public string DeparturePointAddress { get; set; }

        [JsonProperty("departurePointDirections")]
        public string DeparturePointDirections { get; set; }

        [JsonProperty("obfsId")]
        public long ObfsId { get; set; }

        [JsonProperty("leadTravellerFirstname")]
        public string LeadTravellerFirstname { get; set; }

        [JsonProperty("leadTravellerTitle")]
        public string LeadTravellerTitle { get; set; }

        [JsonProperty("lastRetailPrice")]
        public double LastRetailPrice { get; set; }

        [JsonProperty("merchantNetPrice")]
        public double MerchantNetPrice { get; set; }

        [JsonProperty("merchantNetPriceFormatted")]
        public string MerchantNetPriceFormatted { get; set; }

        [JsonProperty("tourGradeDescription")]
        public string TourGradeDescription { get; set; }

        [JsonProperty("savingAmountFormated")]
        public string SavingAmountFormated { get; set; }

        [JsonProperty("bookingEngineId")]
        public string BookingEngineId { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
