using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AttractionResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<Attraction> Attractions { get; set; }
    }

    public partial class Attraction
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("webURL")]
        public object WebUrl { get; set; }

        [JsonProperty("pageUrlName")]
        public string PageUrlName { get; set; }

        [JsonProperty("primaryDestinationUrlName")]
        public string PrimaryDestinationUrlName { get; set; }

        [JsonProperty("publishedDate")]
        public DateTimeOffset PublishedDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("destinationId")]
        public long DestinationId { get; set; }

        [JsonProperty("seoId")]
        public long SeoId { get; set; }

        [JsonProperty("productCount")]
        public long ProductCount { get; set; }

        [JsonProperty("photoCount")]
        public long PhotoCount { get; set; }

        [JsonProperty("primaryDestinationId")]
        public long PrimaryDestinationId { get; set; }

        [JsonProperty("primaryDestinationName")]
        public string PrimaryDestinationName { get; set; }

        [JsonProperty("thumbnailURL")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("thumbnailHiResURL")]
        public string ThumbnailHiResUrl { get; set; }

        [JsonProperty("attractionLatitude")]
        public double AttractionLatitude { get; set; }

        [JsonProperty("attractionLongitude")]
        public double AttractionLongitude { get; set; }

        [JsonProperty("attractionStreetAddress")]
        public string AttractionStreetAddress { get; set; }

        [JsonProperty("attractionCity")]
        public string AttractionCity { get; set; }

        [JsonProperty("attractionState")]
        public string AttractionState { get; set; }
    }

   

    public partial class AttractionResponse
    {
        public static AttractionResponse FromJson(string json) => JsonConvert.DeserializeObject<AttractionResponse>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AttractionResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

 

    

    
}

