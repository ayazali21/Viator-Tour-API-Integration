using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class AttractionRequest
    {
        /// <summary>
        /// destination 
        /// </summary>
        public long destId { get; set; }
        /// <summary>
        /// pagination eg: "1-15"
        /// </summary>
        public string topX { get; set; }
        /// <summary>
        /// Enum of AttractionSortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AttractionSortOrder sortOrder { get; set; }
    }

    public enum AttractionSortOrder
    {
        SEO_PUBLISHED_DATE_D,
        SEO_PUBLISHED_DATE_A,
        SEO_REVIEW_AVG_RATING_D,
        SEO_REVIEW_AVG_RATING_A,
        SEO_ALPHABETICAL
    }

    
}
