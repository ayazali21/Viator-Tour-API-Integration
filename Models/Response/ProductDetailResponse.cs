using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class ProductDetailResponse :CommonResponse
    {
        [JsonProperty("data")]
        public ProductDetail ProductDetail { get; set; }
    }
    public partial class ProductDetailResponse
    {
        public static ProductDetailResponse FromJson(string json) => JsonConvert.DeserializeObject<ProductDetailResponse>(json, Converter.Settings);
    }

    
    public  class ProductDetail
    {
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
        public object OnRequestPeriod { get; set; }

        [JsonProperty("primaryGroupId")]
        public object PrimaryGroupId { get; set; }

        [JsonProperty("pas")]
        public object Pas { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("productUrlName")]
        public string ProductUrlName { get; set; }

        [JsonProperty("primaryDestinationUrlName")]
        public string PrimaryDestinationUrlName { get; set; }

        [JsonProperty("voucherRequirements")]
        public string VoucherRequirements { get; set; }

        [JsonProperty("tourGradesAvailable")]
        public bool TourGradesAvailable { get; set; }

        [JsonProperty("hotelPickup")]
        public bool HotelPickup { get; set; }

        [JsonProperty("userPhotos")]
        public List<UserPhoto> UserPhotos { get; set; }

        [JsonProperty("reviews")]
        public List<Review> Reviews { get; set; }

        [JsonProperty("videos")]
        public object Videos { get; set; }

        [JsonProperty("tourGrades")]
        public List<TourGrade> TourGrades { get; set; }

        [JsonProperty("ageBands")]
        public List<AgeBand> AgeBands { get; set; }

        [JsonProperty("bookingQuestions")]
        public List<BookingQuestions> BookingQuestions { get; set; }

        [JsonProperty("passengerAttributes")]
        public object PassengerAttributes { get; set; }

        [JsonProperty("highlights")]
        public object Highlights { get; set; }

        [JsonProperty("salesPoints")]
        public List<string> SalesPoints { get; set; }

        [JsonProperty("ratingCounts")]
        public Dictionary<string, long> RatingCounts { get; set; }

        [JsonProperty("termsAndConditions")]
        public object TermsAndConditions { get; set; }

        [JsonProperty("maxTravellerCount")]
        public long MaxTravellerCount { get; set; }

        [JsonProperty("itinerary")]
        public string Itinerary { get; set; }

        [JsonProperty("returnDetails")]
        public string ReturnDetails { get; set; }

        [JsonProperty("specialOffer")]
        public string SpecialOffer { get; set; }

        [JsonProperty("destinationId")]
        public long DestinationId { get; set; }

        [JsonProperty("translationLevel")]
        public long TranslationLevel { get; set; }

        [JsonProperty("productPhotos")]
        public List<ProductPhoto> ProductPhotos { get; set; }

        [JsonProperty("voucherOption")]
        public string VoucherOption { get; set; }

        [JsonProperty("applePassSupported")]
        public bool ApplePassSupported { get; set; }

        [JsonProperty("additionalInfo")]
        public List<string> AdditionalInfo { get; set; }

        [JsonProperty("inclusions")]
        public List<string> Inclusions { get; set; }

        [JsonProperty("departureTime")]
        public string DepartureTime { get; set; }

        [JsonProperty("departurePoint")]
        public string DeparturePoint { get; set; }

        [JsonProperty("departureTimeComments")]
        public string DepartureTimeComments { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("mapURL")]
        public object MapUrl { get; set; }

        [JsonProperty("allTravellerNamesRequired")]
        public bool AllTravellerNamesRequired { get; set; }

        [JsonProperty("operates")]
        public string Operates { get; set; }

        [JsonProperty("exclusions")]
        public List<string> Exclusions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("shortTitle")]
        public string ShortTitle { get; set; }

        [JsonProperty("specialOfferAvailable")]
        public bool SpecialOfferAvailable { get; set; }

        [JsonProperty("supplierCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long SupplierCode { get; set; }

        [JsonProperty("priceFormatted")]
        public string PriceFormatted { get; set; }

        [JsonProperty("rrp")]
        public long Rrp { get; set; }

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

        [JsonProperty("thumbnailHiResURL")]
        public string ThumbnailHiResUrl { get; set; }

        [JsonProperty("savingAmountFormated")]
        public string SavingAmountFormated { get; set; }

        [JsonProperty("essential")]
        public object Essential { get; set; }

        [JsonProperty("admission")]
        public object Admission { get; set; }

        [JsonProperty("merchantNetPriceFrom")]
        public double MerchantNetPriceFrom { get; set; }

        [JsonProperty("merchantNetPriceFromFormatted")]
        public string MerchantNetPriceFromFormatted { get; set; }

        [JsonProperty("savingAmount")]
        public long SavingAmount { get; set; }

        [JsonProperty("specialReservation")]
        public bool SpecialReservation { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
    public  class ProductPhoto
    {
        [JsonProperty("photoURL")]
        public string PhotoUrl { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }
    public partial class AgeBand
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("ageFrom")]
        public long AgeFrom { get; set; }

        [JsonProperty("ageTo")]
        public long AgeTo { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("bandId")]
        public long BandId { get; set; }

        [JsonProperty("pluralDescription")]
        public string PluralDescription { get; set; }

        [JsonProperty("treatAsAdult")]
        public bool TreatAsAdult { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Review
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("ownerCountry")]
        public string OwnerCountry { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("productUrlName")]
        public string ProductUrlName { get; set; }

        [JsonProperty("ownerAvatarURL")]
        public string OwnerAvatarUrl { get; set; }

        [JsonProperty("sslSupported")]
        public bool SslSupported { get; set; }

        [JsonProperty("viatorNotes")]
        public string ViatorNotes { get; set; }

        [JsonProperty("viatorFeedback")]
        public string ViatorFeedback { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("submissionDate")]
        public DateTime SubmissionDate { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("review")]
        public string ReviewInfo { get; set; }

        [JsonProperty("publishedDate")]
        public DateTimeOffset PublishedDate { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("reviewId")]
        public long ReviewId { get; set; }
    }

    public partial class TourGrade
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("langServices")]
        public LangServices LangServices { get; set; }

        [JsonProperty("gradeCode")]
        public string GradeCode { get; set; }

        [JsonProperty("merchantNetPriceFrom")]
        public double MerchantNetPriceFrom { get; set; }

        [JsonProperty("merchantNetPriceFromFormatted")]
        public string MerchantNetPriceFromFormatted { get; set; }

        [JsonProperty("priceFrom")]
        public double PriceFrom { get; set; }

        [JsonProperty("gradeTitle")]
        public string GradeTitle { get; set; }

        [JsonProperty("gradeDepartureTime")]
        public string GradeDepartureTime { get; set; }

        [JsonProperty("gradeDescription")]
        public string GradeDescription { get; set; }

        [JsonProperty("defaultLanguageCode")]
        public string DefaultLanguageCode { get; set; }

        [JsonProperty("priceFromFormatted")]
        public string PriceFromFormatted { get; set; }
    }

    public partial class LangServices
    {
        [JsonProperty("en/SERVICE_AUDIO")]
        public string EnServiceAudio { get; set; }
    }

    public partial class UserPhoto
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("ownerCountry")]
        public string OwnerCountry { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("productUrlName")]
        public string ProductUrlName { get; set; }

        [JsonProperty("ownerAvatarURL")]
        public string OwnerAvatarUrl { get; set; }

        [JsonProperty("sslSupported")]
        public bool SslSupported { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("timeUploaded")]
        public DateTimeOffset TimeUploaded { get; set; }

        [JsonProperty("editorsPick")]
        public bool EditorsPick { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("thumbnailURL")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("photoId")]
        public long PhotoId { get; set; }

        [JsonProperty("photoURL")]
        public string PhotoUrl { get; set; }

        [JsonProperty("photoHiResURL")]
        public string PhotoHiResUrl { get; set; }

        [JsonProperty("photoMediumResURL")]
        public string PhotoMediumResUrl { get; set; }
    }

    public class BookingQuestions
    {
        public int sortOrder { get; set; }
        public string title { get; set; }
        public int questionId { get; set; }
        public string stringQuestionId { get; set; }
        public string subTitle { get; set; }
        public bool required { get; set; }
        public string message { get; set; }
    }
}
