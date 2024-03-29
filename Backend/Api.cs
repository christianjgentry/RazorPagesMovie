﻿using System.Threading.Tasks;
using System.Net.Http;
using RazorPagesMovie.Models;


namespace RazorPagesMovie.Backend
{
    public class Api
    {
        static HttpClient client = new HttpClient();

        public static async Task<Movie2> GetMovieAsync(string movietitle)
        {
            Movie2 movie = null;
            HttpResponseMessage response = await client.GetAsync("http://omdbapi.com/?apikey=" + APIKeys.OmdbKey + "&t=" + movietitle);
            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie2>();
            }
            return movie;

        }
    }
}
