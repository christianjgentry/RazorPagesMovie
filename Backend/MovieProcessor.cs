using System;
using System.Net.Http;
using System.Threading.Tasks;
using RazorPagesMovie.Models;

namespace Library
{
    public class MovieProcessor
    {
        public async Task<Movie> LoadMovie(string movieName = "")
        {
            string url = "";

            if (movieName != "")
            {
                url = $"http://www.omdbapi.com/";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Movie movie = await response.Content.ReadAsAsync<Movie>();

                    return movie;
                }

                else {

                    throw new Exception(response.ReasonPhrase);

                }
            }

        }
    }
}
