using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Tour.Domain.Models.Viator.Response
{
  
    public partial class CategoryResponse : CommonResponse
    {
        [JsonProperty("data")]
        public List<Category> Categories { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("thumbnailURL")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("subcategories")]
        public List<Subcategory> Subcategories { get; set; }

        [JsonProperty("thumbnailHiResURL")]
        public string ThumbnailHiResUrl { get; set; }

        [JsonProperty("productCount")]
        public long ProductCount { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupUrlName")]
        public string GroupUrlName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class Subcategory
    {
        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }

        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("subcategoryId")]
        public long SubcategoryId { get; set; }

        [JsonProperty("subcategoryUrlName")]
        public string SubcategoryUrlName { get; set; }

        [JsonProperty("subcategoryName")]
        public string SubcategoryName { get; set; }
    }

 

    public partial class CategoryResponse
    {
        public static CategoryResponse FromJson(string json) => JsonConvert.DeserializeObject<CategoryResponse>(json, Converter.Settings);
    } 
}

