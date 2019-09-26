using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class ProductReviewRequest
    {
        public string code { get; set; }
        public string topX { get; set; }
        public ProductReviewSort sortOrder { get; set; }
    }

    public enum ProductReviewSort
    {
        /// <summary>
        /// Traveler Rating (low→high) (not averages)
        /// </summary>
        REVIEW_RATING_A,
        /// <summary>
        /// Traveler Rating (high→low) (not averages)
        /// </summary>
        REVIEW_RATING_D,
        /// <summary>
        /// Most recent review
        /// </summary>
        REVIEW_RATING_SUBMISSION_DATE_D
    }
}
