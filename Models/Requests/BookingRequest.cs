using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.Domain.Models.Viator.Requests
{
    public class BookingRequest
    {
        public string sessionId { get; set; }

        public string ipAddress { get; set; }

        public object aid { get; set; }

        public bool newsletterSignUp { get; set; }

        public bool demo { get; set; }

        public object promoCode { get; set; }

        public string currencyCode { get; set; }

        public object otherDetail { get; set; }

        public PartnerDetail partnerDetail { get; set; }

        public Booker booker { get; set; }

        public List<BookingItem> items { get; set; }
    }


    public class PartnerDetail
    {
        public string distributorRef { get; set; }
    }

    public class Booker
    {

        public string email { get; set; }

        public string homePhone { get; set; }

        public string firstname { get; set; }

        public string surname { get; set; }

        public string title { get; set; }

        public string cellPhoneCountryCode { get; set; }

        public string cellPhone { get; set; }
    }


    public class PartnerItemDetail
    {

        public string distributorItemRef { get; set; }
    }


    public class BookingQuestionAnswer
    {

        public int questionId { get; set; }

        public string answer { get; set; }
    }


    public class BookingTraveller
    {

        public int bandId { get; set; }

        public string firstname { get; set; }

        public string surname { get; set; }

        public string title { get; set; }

        public bool leadTraveller { get; set; }
    }


    public class BookingItem
    {

        public PartnerItemDetail partnerItemDetail { get; set; }

        public object hotelId { get; set; }

        public object pickupPoint { get; set; }

        public string travelDate { get; set; }

        public string productCode { get; set; }

        public string tourGradeCode { get; set; }

        public string languageOptionCode { get; set; }

        public List<BookingQuestionAnswer> bookingQuestionAnswers { get; set; }

        public string specialRequirements { get; set; }

        public List<BookingTraveller> travellers { get; set; }
    }
}
