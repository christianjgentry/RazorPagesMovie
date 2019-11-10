using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using RazorPagesMovie.Models;


namespace RazorPagesMovie.Backend
{
    public class ApiTest
    {
        static HttpClient client = new HttpClient();

        public static async Task<NewMovie> GetMovieAsync(string movietitle)
        {
            NewMovie movie = null;
            HttpResponseMessage response = await client.GetAsync("http://omdbapi.com/?apikey=" + APIKeys.OmdbKey + "&t=" + movietitle);
            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<NewMovie>();
            }
            return movie;

        }
    }
}
