using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Tour.Domain.Models.Viator.Response
{

    public partial class LocationResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<Locations> Locations { get; set; }
    }

    public partial class Locations
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("destinationUrlName")]
        public string DestinationUrlName { get; set; }

        [JsonProperty("defaultCurrencyCode")]
        public string DefaultCurrencyCode { get; set; }

        [JsonProperty("lookupId")]
        public string LookupId { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("iataCode")]
        public string IataCode { get; set; }

        [JsonProperty("destinationType")]
        public DestinationType DestinationType { get; set; }

        [JsonProperty("destinationName")]
        public string DestinationName { get; set; }

        [JsonProperty("destinationId")]
        public long DestinationId { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }

    

    public enum DestinationType { City, Country, Region };

    public partial class LocationResponse
    {
        public static LocationResponse FromJson(string json) => JsonConvert.DeserializeObject<LocationResponse>(json, Converter.Settings);
    }


    internal class DestinationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DestinationType) || t == typeof(DestinationType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CITY":
                    return DestinationType.City;
                case "COUNTRY":
                    return DestinationType.Country;
                case "REGION":
                    return DestinationType.Region;
            }
            throw new Exception("Cannot unmarshal type DestinationType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DestinationType)untypedValue;
            switch (value)
            {
                case DestinationType.City:
                    serializer.Serialize(writer, "CITY");
                    return;
                case DestinationType.Country:
                    serializer.Serialize(writer, "COUNTRY");
                    return;
                case DestinationType.Region:
                    serializer.Serialize(writer, "REGION");
                    return;
            }
            throw new Exception("Cannot marshal type DestinationType");
        }

        public static readonly DestinationTypeConverter Singleton = new DestinationTypeConverter();
    }

}
