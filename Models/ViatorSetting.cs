using System;
using System.Collections.Generic;
using System.Text;

namespace Viator.Api.Models
{
    public class ViatorSetting
    {
        public string BaseAddress { get; set; }
        public string ApiKey { get; set; }
        public bool IsDemo { get; set; }

        /// <summary>
        /// number of record to be fetched based on destination from viator API (P.S Max is 500)
        /// </summary>
        public int FetchRecordCount { get; set; }

        public string CurrencyCode { get; set; }
        public int REDIS_HASHSET_EXPIRY_IN_MINUITES { get; set; }
    }
}
