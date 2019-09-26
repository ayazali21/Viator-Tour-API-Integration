using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class CalculateBookingPriceRequest
    {
        public string promoCode { get; set; }

        public object partnerDetail { get; set; }

        public string currencyCode { get; set; }

        public List<Item> items { get; set; }
    }
    public class Traveller
    {
        public int bandId { get; set; }
    }

    public class Item
    {
        public bool specialReservation { get; set; }

        public string travelDate { get; set; }

        public string productCode { get; set; }

        public string tourGradeCode { get; set; }

        public List<Traveller> travellers { get; set; }
    }
}
