using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class BookingStatusRequest
    {
        public string bookingDateFrom { get; set; }

        public string bookingDateTo { get; set; }

        public int itineraryIds { get; set; }

        public int itemIds { get; set; }

        public string distributorRefs { get; set; }

        public string distributorItemRefs { get; set; }

        public string leadFirstName { get; set; }

        public string leadSurname { get; set; }
    }
}
