using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class ProductSearchByCodeRequest
    {
        public string currencyCode { get; set; }

        public string[] productCodes { get; set; }
    }
}
