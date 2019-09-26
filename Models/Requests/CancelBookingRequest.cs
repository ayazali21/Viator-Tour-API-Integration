using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class CancelBookingRequest
    {
        public int itineraryId { get; set; }
        public string distributorRef { get; set; }
        public List<CancelItem> cancelItems { get; set; }
    }
    public class CancelItem
    {
        public int itemId { get; set; }
        public string distributorItemRef { get; set; }
        public string cancelCode { get; set; }
        public string cancelDescription { get; set; }
    }
}
