using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class ProductAvailabilityRequest
    {
        public string currencyCode { get; set; }

        public string startDate { get; set; }

        public string endDate { get; set; }

        public string numAdults { get; set; }

        public string[] productCodes { get; set; }
    }
}
