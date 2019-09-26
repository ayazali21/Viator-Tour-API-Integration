using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Viator.Api.Utility
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri, Dictionary<string, string> requestHeaders = null, string authorizationToken = null, string authorizationMethod = "Bearer");

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item, Dictionary<string, string> requestHeaders = null, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");

        Task<HttpResponseMessage> DeleteAsync(string uri, Dictionary<string, string> requestHeaders = null, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");

        Task<HttpResponseMessage> PutAsync<T>(string uri, T item, Dictionary<string, string> requestHeaders = null, string authorizationToken = null, string requestId = null, string authorizationMethod = "Bearer");

        void SetTimeOut(TimeSpan timeOut);
    }
}
