using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class ProductReviewResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<ProductReviewDetail> ProductReviewDetail { get; set; }
    }
    public partial class ProductReviewResponse
    {
        public static ProductReviewResponse FromJson(string json) => JsonConvert.DeserializeObject<ProductReviewResponse>(json, Converter.Settings);
    }
    public partial class ProductReviewDetail
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
        public DateTimeOffset SubmissionDate { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("publishedDate")]
        public DateTimeOffset PublishedDate { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("reviewId")]
        public long ReviewId { get; set; }
    }
}
