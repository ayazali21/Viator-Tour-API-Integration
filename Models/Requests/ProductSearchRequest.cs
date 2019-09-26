using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public  class ProductSearchRequest
    {


        public string startDate { get; set; }

        public string endDate { get; set; }

        public string topX { get; set; }

        public int destId { get; set; }

        public string currencyCode { get; set; }

        public int catId { get; set; }

        public int subCatId { get; set; }

        public bool dealsOnly { get; set; }
        /// <summary>
        /// Enum of type ProductSortOrder
        /// </summary>
        public string sortOrder { get; set; }
    }

    public enum ProductSortOrder
    {
        /// <summary>
        /// The top sellers - default sortOrder
        /// </summary>
        TOP_SELLERS,
        /// <summary>
        /// Traveler Rating (low->high) Average
        /// </summary>
        REVIEW_AVG_RATING_A,
        /// <summary>
        /// Traveler Rating (high->low) Average
        /// </summary>
        REVIEW_AVG_RATING_D,
        /// <summary>
        /// Price (low->high)
        /// </summary>
        PRICE_FROM_A,
        /// <summary>
        /// Price (high->low)
        /// </summary>
        PRICE_FROM_D
    }
}
