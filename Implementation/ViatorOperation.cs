using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Tour.Domain.Models.Viator.Requests;
using Tour.Domain.Models.Viator.Response;
using Viator.Api.Models;
using Viator.Api.Utility;

namespace Viator.Api.Implementation
{
    public class ViatorOperation
    {
        #region Fields
        private readonly IHttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseAddress;
        private readonly string _defaultCurrencyCode;
        #endregion


        #region Ctor
        public ViatorOperation(IHttpClient httpClient, ViatorSetting viatorSetting)
        {
            _httpClient = httpClient;
            _apiKey = viatorSetting.ApiKey;
            _baseAddress = viatorSetting.BaseAddress;
            _defaultCurrencyCode = viatorSetting.CurrencyCode;
        }
        #endregion

        #region General

        public List<string> GetAvailableCurrencyCode()
        {
            return new List<string>() { "USD", "GBP", "EUR", "AUD", "CAD", "NZD", "SGD", "HKD" };
        }
        public string GetDefaultCurrencyCodeIfNotExist(string currencyCode)
        {
            return _defaultCurrencyCode;///GetAvailableCurrencyCode().Contains(currencyCode) ? currencyCode : "USD";
        }

        public string GenerateQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }

        private string GenerateBaseURL(string uri, ViatorSetting setting = null)
        {
            if (setting == null)
                return $"{_baseAddress}/{uri}?apiKey={_apiKey}";
            else
                return $"{setting.BaseAddress}/{uri}?apiKey={setting.ApiKey}";

        }


        private Dictionary<string, string> ConvertToDictionary<T>(T obj)
        {
            return obj.GetType()
               .GetProperties(BindingFlags.Instance | BindingFlags.Public)
             .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj, null).ToString());
        }

        #endregion

        #region Methods

        #region Taxonomy API's
        #region Location
        /// <summary>
        /// Get Location/Destination list
        /// </summary>
        /// <returns></returns>
        public async Task<LocationResponse> GetLocations(ViatorSetting setting = null)
        {

            var uri = $"service/taxonomy/locations";
            var response = await _httpClient.GetStringAsync(GenerateBaseURL(uri,setting));
            var result = LocationResponse.FromJson(response);

            return result;
        }


        #endregion

        #region Category
        public async Task<CategoryResponse> GetCategories(string destId, ViatorSetting setting = null)
        {
            var uri = $"service/taxonomy/categories";

            string fullURL = $"{GenerateBaseURL(uri,setting)}&destId={destId}";

            var response = await _httpClient.GetStringAsync(fullURL);
            var result = CategoryResponse.FromJson(response);
            return result;
        }

        #endregion

        #region Attractions
        public async Task<AttractionResponse> GetAttraction(AttractionRequest attractionRequest, ViatorSetting setting = null)
        {

            var uri = $"service/taxonomy/attractions";
            var response = await _httpClient.PostAsync<AttractionRequest>(GenerateBaseURL(uri,setting), attractionRequest);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = AttractionResponse.FromJson(content);
                if (result.Attractions.Count == 0)
                    throw new Exception("Viator API - GetAttraction : Empty response return from server");
                return result;
            }
            else
                throw new Exception("Viator API - GetAttraction: Api error response");

        }
        #endregion

        #endregion

        #region Search API's

        #region Products Search By Category , Location 
        public async Task<ProductSearchResponse> ProductSearch(ProductSearchRequest productSearchModel, ViatorSetting setting = null)
        {
            var uri = $"service/search/products";
            var response = await _httpClient.PostAsync<ProductSearchRequest>(GenerateBaseURL(uri,setting), productSearchModel);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = ProductSearchResponse.FromJson(content);

                return result;
            }
            else
                throw new Exception("Viator API - ProductSearch: Api error response");

        }

        #endregion

        #region Product Search By Code's
        public async Task<ProductSearchResponse> ProductSearchByCode(ProductSearchByCodeRequest productSearchByCodeModel, ViatorSetting setting = null)
        {
            var uri = $"service/search/products/codes";
            try
            {
                var response = await _httpClient.PostAsync<ProductSearchByCodeRequest>(GenerateBaseURL(uri,setting), productSearchByCodeModel);
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var result = ProductSearchResponse.FromJson(content);
                    return result;
                }
                else
                    throw new Exception($"Viator API - ProductSearchByCode: Api error response - {response.Content} ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Free text search (ie search across all products and destinations.)
        public async Task<FreeTextSearchResponse> FreeTextSearch(FreeTextSearchRequest freeTextSearchModel, ViatorSetting setting = null)
        {
            var uri = $"service/search/freetext";
            var response = await _httpClient.PostAsync<FreeTextSearchRequest>(GenerateBaseURL(uri,setting), freeTextSearchModel);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = FreeTextSearchResponse.FromJson(content);
                if (result.Data.Count == 0)
                    throw new Exception("Viator API - FreeTextSearch : Empty response return from server");
                return result;
            }
            else
                throw new Exception("Viator API - FreeTextSearch: Api error response");

        }

        #endregion

        #endregion

        #region Product API's

        #region Get Product Detail
        /// <summary>
        /// Get Product Details
        /// </summary>
        /// <param name="code"></param>
        /// <param name="currencyCode"></param>
        /// <param name="excludeTourGradeAvailability"></param>
        /// <param name="showUnavailable"></param>
        /// <returns></returns>
        public async Task<ProductDetailResponse> GetProductDetailInfo(ProductDetailRequest productDetailModel, ViatorSetting setting = null)
        {
            var uri = $"service/product";
            string finalURL = $"{GenerateBaseURL(uri, setting)}&{GenerateQueryString(productDetailModel)}";
            var response = await _httpClient.GetStringAsync(finalURL);
            var result = ProductDetailResponse.FromJson(response);

            return result;
        }

        #endregion

        #region Get Product Reviews 
        /// <summary>
        /// Gets Product Reviews list
        /// </summary>
        /// <param name="productReviewModel"></param>
        /// <returns></returns>
        public async Task<ProductReviewResponse> GetProductReviews(ProductReviewRequest productReviewModel, ViatorSetting setting = null)
        {
            var uri = $"service/product/reviews";
            string fullURL = $"{GenerateBaseURL(uri, setting)}&{GenerateQueryString(productReviewModel)}";
            var response = await _httpClient.GetStringAsync(fullURL);
            var result = ProductReviewResponse.FromJson(response);

            return result;
        }

        #endregion

        #region Get Product Photos
        /// <summary>
        /// Get product photos list
        /// </summary>
        /// <param name="code"> product code</param>
        /// <param name="topX">pagination</param>
        /// <returns></returns>
        public async Task<ProductPhotoResponse> GetProductPhotos(string code, string topX, bool showUnavailable = false, ViatorSetting setting = null)
        {
            var uri = $"service/product/photos";
            string fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { code, topX, showUnavailable })}";

            var response = await _httpClient.GetStringAsync(fullURL);
            var result = ProductPhotoResponse.FromJson(response);

            return result;
        }
        #endregion

        #region Product Availabilty
        /// <summary>
        /// Get product availibility list based on product code
        /// </summary>
        /// <param name="productAvailabilityModel"></param>
        /// <returns></returns>
        public async Task<string> AvailableProducts(ProductAvailabilityRequest productAvailabilityModel, ViatorSetting setting = null)
        {
            var uri = $"service/available/products";

            var response = await _httpClient.PostAsync<ProductAvailabilityRequest>(GenerateBaseURL(uri,setting), productAvailabilityModel);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;

                if (string.IsNullOrEmpty(result))
                    throw new Exception("Viator API - AvailableProducts : Empty response return from server");
                return result;
            }
            else
                throw new Exception("Viator API - AvailableProducts: Api error response");
        }
        #endregion

        #endregion

        #region booking
        /// <summary>
        /// //Get All available dates for a product excluding weekdays
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public async Task<BookingAvaialbilityDates> GetAvailabeDate(string productCode, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/availability/dates";
            string fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { productCode })}";
            var response = await _httpClient.GetStringAsync(fullURL);
            var result = BookingAvaialbilityDates.FromJson(response);

            return result;
        }

        public async Task<BookingAvailableTourGrade> AvailableTourGrades(BookingTourGradeRequest bookingTourGradeRequest, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/availability/tourgrades";
            var response = await _httpClient.PostAsync<BookingTourGradeRequest>(GenerateBaseURL(uri,setting), bookingTourGradeRequest);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = BookingAvailableTourGrade.FromJson(content);

                return result;
            }
            else
                throw new Exception("Viator API - Tour Grade: Api error response");
        }

        public async Task<MonthlyAvailableTourGrades> AvailableMonthlyAvailableTourGrades(string productCode, int month, int year, string currencyCode, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/availability/tourgrades/pricingmatrix";
            var request = new MonthlyAvailableTourGradesRequest() { productCode = productCode, currencyCode = currencyCode, month = month.ToString(), year = year.ToString() };
            var response = await _httpClient.PostAsync<MonthlyAvailableTourGradesRequest>(GenerateBaseURL(uri,setting), request);


            var content = response.Content.ReadAsStringAsync().Result;
            var result = MonthlyAvailableTourGrades.FromJson(content);

            return result;

        }

        /// <summary>
        ///  //Calculate price before confirmation booking to confirm the availabity of product on chosen date
        /// </summary>
        /// <param name="calculatePriceModel"></param>
        /// <returns></returns>
        public async Task<CalculatedBookingPriceResponse> CalculatePrice(CalculateBookingPriceRequest calculatePriceModel, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/calculateprice";
            var response = await _httpClient.PostAsync<CalculateBookingPriceRequest>(GenerateBaseURL(uri,setting), calculatePriceModel);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = CalculatedBookingPriceResponse.FromJson(content);
                return result;
            }
            else
                throw new Exception("Viator API - Calculate Price: Api error response");
        }

        /// <summary>
        /// //Get availabe Hotels list for chosen product
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public async Task<HotelResponseModel> GetHotels(string productCode, long destId, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/hotels";
            string fullURL;
            if (!string.IsNullOrEmpty(productCode))
            {
                fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { productCode })}";
            }
            else
                fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { destId })}";

            var response = await _httpClient.GetStringAsync(fullURL);
            return JsonConvert.DeserializeObject<HotelResponseModel>(response);
        }


        /// <summary>
        /// cofirm booking 
        /// </summary>
        /// <param name="bookingModel"></param>
        /// <returns></returns>
        public async Task<BookingResponse> MakeBooking(BookingRequest bookingModel, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/book";
            var response = await _httpClient.PostAsync<BookingRequest>(GenerateBaseURL(uri,setting), bookingModel);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = BookingResponse.FromJson(content);
                return result;
            }
            else
                throw new Exception("Viator API - Booking: Api error response");
        }


        /// <summary>
        /// //get all booking for customer
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="voucherKey"></param>
        /// <param name="email"></param>
        /// <param name="lastCCFourDigits"></param>
        /// <param name="itineraryOrItemId"></param>
        /// <returns></returns>

        public async Task<string> MyBooking(string voucherKey, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/mybookings";
            string fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { voucherKey })}";
            var response = await _httpClient.GetStringAsync(fullURL);
            return response;
        }

        /// <summary>
        /// returns only one booking at a tim
        /// </summary>
        /// <param name="voucherKey"></param>
        /// <returns></returns>
        public async Task<string> MyPastBooking(string voucherKey, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/pastbooking";
            string fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { voucherKey })}";
            var response = await _httpClient.GetStringAsync(fullURL);
            return response;
        }


        /// <summary>
        /// get voucher detail 
        /// </summary>
        /// <param name="voucherKey"></param>
        /// <returns></returns>
        public async Task<string> Voucher(string voucherKey, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/voucher";
            string fullURL = $"{GenerateBaseURL(uri,setting)}&{GenerateQueryString(new { voucherKey })}";
            var response = await _httpClient.GetStringAsync(fullURL);
            return response;
        }


        public async Task<BookingStatusResponse> BookingStatus(BookingStatusRequest bookingStatusModel, ViatorSetting setting = null)
        {
            var uri = $"/service/booking/status";
            var response = await _httpClient.PostAsync<BookingStatusRequest>(GenerateBaseURL(uri,setting), bookingStatusModel);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = BookingStatusResponse.FromJson(content);
                return result;
            }
            else
                throw new Exception("Viator API - Booking Status: Api error response");
        }
        #endregion

        #region Cancel merchant Api booking
        /// <summary>
        /// cancel booking 
        /// </summary>
        /// <param name="bookingModel"></param>
        /// <returns></returns>
        public async Task<CancelBookingResponse> CancelMerchantBooking(CancelBookingRequest cancelBookingModel, ViatorSetting setting = null)
        {
            var uri = $"/service/merchant/cancellation";
            var response = await _httpClient.PostAsync<CancelBookingRequest>(GenerateBaseURL(uri,setting), cancelBookingModel);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var result = CancelBookingResponse.FromJson(content);
                return result;
            }
            else
                throw new Exception("Viator API - Booking Status: Api error response");
        }

        #endregion

        #endregion
    }
}
