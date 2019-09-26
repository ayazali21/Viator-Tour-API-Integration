using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public partial class ProductPhotoResponse:CommonResponse
    {
        [JsonProperty("data")]
        public List<ProductPhotoDetails> ProductPhotoDetails { get; set; }
    }
    public partial class ProductPhotoResponse
    {
        public static ProductPhotoResponse FromJson(string json) => JsonConvert.DeserializeObject<ProductPhotoResponse>(json, Converter.Settings);
    }

    public partial class ProductPhotoDetails
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

        [JsonProperty("editorsPick")]
        public bool EditorsPick { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("thumbnailURL")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("timeUploaded")]
        public DateTimeOffset TimeUploaded { get; set; }

        [JsonProperty("photoId")]
        public long PhotoId { get; set; }

        [JsonProperty("photoURL")]
        public string PhotoUrl { get; set; }

        [JsonProperty("photoHiResURL")]
        public string PhotoHiResUrl { get; set; }

        [JsonProperty("photoMediumResURL")]
        public string PhotoMediumResUrl { get; set; }
    }

}
