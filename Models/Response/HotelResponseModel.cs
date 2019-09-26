using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Response
{
    public class HotelResponseModel
    {
        public IList<Hotels> data { get; set; }
        public bool success { get; set; }
        public int totalCount { get; set; }
    }
    public class Hotels
    {
        public int sortOrder { get; set; }
        public string brand { get; set; }
        public string hotelString { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public int destinationId { get; set; }
        public string phone { get; set; }
        public object productCodes { get; set; }
        public string city { get; set; }
        public object notes { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }
}
