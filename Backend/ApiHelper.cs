using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Library
{
    public static class ApiHelper
    {

        // May need to remove static to have multiple calls.
        public static HttpClient ApiClient { get; set; } 
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
