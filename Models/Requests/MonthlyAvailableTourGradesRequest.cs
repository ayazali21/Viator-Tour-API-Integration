using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class MonthlyAvailableTourGradesRequest
    {
        public string productCode { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string currencyCode { get; set; }
    }
}
