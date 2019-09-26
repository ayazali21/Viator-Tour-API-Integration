using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class BookingTourGradeRequest
    {
        public string productCode { get; set; }

        public string bookingDate { get; set; }

        public string currencyCode { get; set; }

        public List<AgeBand> ageBands { get; set; }
    }
    public class AgeBand
    {
        public int bandId { get; set; }

        public int count { get; set; }
    }
}
