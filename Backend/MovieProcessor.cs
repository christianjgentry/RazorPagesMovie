using System;
using System.Net.Http;
using System.Threading.Tasks;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Backend
{
    public class MovieProcessor
    {
        public static async Task<Movie> LoadMovie(string movieName = "")
        {
          
          string url = $"http://www.omdbapi.com/?apikey=" + APIKeys.OmdbKey + "&t=" + movieName;
                

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
