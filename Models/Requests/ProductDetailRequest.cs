using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class ProductDetailRequest
    {
        public string code { get; set; }
        public string currencyCode { get; set; }
        public bool excludeTourGradeAvailability { get; set; }
        public bool showUnavailable { get; set; }
      
    }
}
