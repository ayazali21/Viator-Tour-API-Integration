using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Tour.Domain.Models.Viator.Requests;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class FreeTextSearchResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<ProductReview> Data { get; set; }
    }

    public partial class ProductReview
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
        //TODO: Deserialize to object dynamic class
        /// <summary>
        /// Here it contain dynamic response of type Product Response,Location/Destination Response and Attraction
        /// </summary>
        [JsonProperty("data")]
        public string Data {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
              
                switch (Enum.Parse<SearchTypes>(SearchType))
                {
                    case SearchTypes.PRODUCT:
                        {
                            Product = new Product();
                            Product = JsonConvert.DeserializeObject<Product>(value);
                        }
                        break;
                    case (SearchTypes.ATTRACTION | SearchTypes.RECOMMENDATION):
                        {
                            Attraction = new Attraction();
                            Attraction = JsonConvert.DeserializeObject<Attraction>(value);
                        }
                        break;
                    case SearchTypes.DESTINATION:
                        {
                            Location = new Locations();
                            Location = JsonConvert.DeserializeObject<Locations>(value);
                        }
                        break;
                    default:break;
                }
            }
        }

        public Product Product = null;
        public Locations Location = null;
        public Attraction Attraction = null;
        /// <summary>
        /// Enum of SearchType
        /// </summary>
        [JsonProperty("searchType")]
        public string SearchType { get; set; }
    }

    public partial class FreeTextSearchResponse
    {
        public static FreeTextSearchResponse FromJson(string json) => JsonConvert.DeserializeObject<FreeTextSearchResponse>(json, Converter.Settings);
    }

}
