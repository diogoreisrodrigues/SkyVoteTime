using RestSharp;
using SkyVoteTime.Shared.Models;
using Newtonsoft.Json;

namespace SkyVoteTime.Client.API
{
    public class TheMovieDBApi
    {
        private string apiKey = "8ec9575a406e1b25a8d68e65b07e7319";

        public HttpClient client = new HttpClient();
        
        public string PopularData { get; set; }

        public string UpcomingMovie { get; set; }

        private MovieList movieList;



        /*
        public async Task<List<Movie>> GetPopularMoviesAsync()
        {
            var client = new RestClient("https://api.themoviedb.org/3");
            var request = new RestRequest("/discover/movie?sort_by=popularity.desc", Method.Get);
            request.AddParameter("api_key", apiKey);
            var response = await client.ExecuteAsync<List<Movie>>(request);
            var movies = response.Data;
            return movies;
        }
        */
        public async Task<MovieList> UpcomingMovieDetails()
        {
            clearYourHead(); // 
            // grab upcoming movie details
            HttpResponseMessage upcomingMovie = await client.GetAsync(
                "https://api.themoviedb.org/3/movie/upcoming?api_key=8ec9575a406e1b25a8d68e65b07e7319&language=en-US&page=1");
            if (upcomingMovie.IsSuccessStatusCode)
            {
                UpcomingMovie = await upcomingMovie.Content.ReadAsStringAsync();
                movieList = JsonConvert.DeserializeObject<MovieList>(UpcomingMovie);
                return movieList;
            }
            else
            {
                UpcomingMovie = null;
                return null;
            }
        }//grab 

        public void clearYourHead()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));
        }

    }
}
