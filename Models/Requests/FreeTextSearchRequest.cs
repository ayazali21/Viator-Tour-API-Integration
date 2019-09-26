using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class FreeTextSearchRequest
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
        ///List of SearchTypes
        /// </summary>
        public List<string> searchTypes { get; set; }

        public string CurrencyCode { get; set; }
        /// <summary>
        /// The keyword to search on
        /// </summary>
        public string Text { get; set; }
    }

    public enum SearchTypes
    {
        /// <summary>
        /// a tour / activity
        /// </summary>
        PRODUCT,
        /// <summary>
        /// continent, country, city, region
        /// </summary>
        DESTINATION,
        /// <summary>
        /// an attraction within a destination
        /// </summary>
        ATTRACTION,
        /// <summary>
        /// recommendation of an attraction from the customer
        /// </summary>
        RECOMMENDATION
    }
}
