using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tour.Domain.Models.Viator.Response
{

    public partial class ProductSearchResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<Product> Products { get; set; }
    }

    public  class Product
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("supplierName")]
        public string SupplierName { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("catIds")]
        public List<long> CatIds { get; set; }

        [JsonProperty("subCatIds")]
        public List<long> SubCatIds { get; set; }

        [JsonProperty("webURL")]
        public object WebUrl { get; set; }

        [JsonProperty("specialReservationDetails")]
        public object SpecialReservationDetails { get; set; }

        [JsonProperty("sslSupported")]
        public bool SslSupported { get; set; }

        [JsonProperty("panoramaCount")]
        public long PanoramaCount { get; set; }

        [JsonProperty("merchantCancellable")]
        public bool MerchantCancellable { get; set; }

        [JsonProperty("bookingEngineId")]
        public string BookingEngineId { get; set; }

        [JsonProperty("onRequestPeriod")]
        public long? OnRequestPeriod { get; set; }

        [JsonProperty("primaryGroupId")]
        public long? PrimaryGroupId { get; set; }

        [JsonProperty("pas")]
        public object Pas { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("productUrlName")]
        public string ProductUrlName { get; set; }

        [JsonProperty("primaryDestinationUrlName")]
        public string PrimaryDestinationUrlName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("supplierCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SupplierCode { get; set; }

        [JsonProperty("translationLevel")]
        public long TranslationLevel { get; set; }

        [JsonProperty("thumbnailHiResURL")]
        public string ThumbnailHiResUrl { get; set; }

        [JsonProperty("priceFormatted")]
        public string PriceFormatted { get; set; }

        [JsonProperty("rrp")]
        public double Rrp { get; set; }

        [JsonProperty("rrpformatted")]
        public string Rrpformatted { get; set; }

        [JsonProperty("onSale")]
        public bool OnSale { get; set; }

        [JsonProperty("photoCount")]
        public long PhotoCount { get; set; }

        [JsonProperty("reviewCount")]
        public long ReviewCount { get; set; }

        [JsonProperty("primaryDestinationId")]
        public long PrimaryDestinationId { get; set; }

        [JsonProperty("primaryDestinationName")]
        public string PrimaryDestinationName { get; set; }

        [JsonProperty("thumbnailURL")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("videoCount")]
        public long VideoCount { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("shortTitle")]
        public string ShortTitle { get; set; }

        [JsonProperty("merchantNetPriceFrom")]
        public double MerchantNetPriceFrom { get; set; }

        [JsonProperty("merchantNetPriceFromFormatted")]
        public string MerchantNetPriceFromFormatted { get; set; }

        [JsonProperty("savingAmountFormated")]
        public string SavingAmountFormated { get; set; }

        [JsonProperty("essential")]
        public string Essential { get; set; }

        [JsonProperty("admission")]
        public string Admission { get; set; }

        [JsonProperty("specialOfferAvailable")]
        public bool SpecialOfferAvailable { get; set; }

        [JsonProperty("specialReservation")]
        public bool SpecialReservation { get; set; }

        [JsonProperty("uniqueShortDescription")]
        public object UniqueShortDescription { get; set; }

        [JsonProperty("savingAmount")]
        public long SavingAmount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

 

   
    public partial class ProductSearchResponse
    {
        public static ProductSearchResponse FromJson(string json) => JsonConvert.DeserializeObject<ProductSearchResponse>(json, Converter.Settings);
    }
 
}

