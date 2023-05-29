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

        public string PersonList { get; set; }

        public PersonList personList;

        private MovieList movieList;

        private Movie movie;

       

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

        public async Task<Movie> GrabMovieAsync(int movieID)
        {
            clearYourHead(); // 

            // grabs the movie info
            HttpResponseMessage movieInfo =
                await client.GetAsync("https://api.themoviedb.org/3/movie/" +
                    movieID + "?api_key=d194eb72915bc79fac2eb1a70a71ddd3&language=en-US");
            // grabs the movie credits - includes cast
            Console.WriteLine(movieID);
            // null checks
            if (movieInfo.IsSuccessStatusCode)
            {
                string Details = await movieInfo.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(Details);
                return movie;
            }
            else
            {
                return null;
            }
            
        } // GrabMovieAsync()

        public async Task<MovieList> searchMovieDetails(string Query)
        {
            clearYourHead(); // 
            // grab upcoming movie details
            HttpResponseMessage upcomingMovie = await client.GetAsync(
                "https://api.themoviedb.org/3/search/movie?api_key=8ec9575a406e1b25a8d68e65b07e7319&language=en-US&query=" + Query);
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

        

        public async Task<List<Person>> searchPersonDetails(string Query)
        {
            clearYourHead(); // 
            // grab upcoming movie details
            HttpResponseMessage personListHttp = await client.GetAsync(
                "https://api.themoviedb.org/3/search/person?api_key=8ec9575a406e1b25a8d68e65b07e7319&language=en-US&query="+ Query );
            if (personListHttp.IsSuccessStatusCode)
            {
                PersonList = await personListHttp.Content.ReadAsStringAsync();
                personList = JsonConvert.DeserializeObject<PersonList>(PersonList);
                return personList.results;
            }
            else
            {
                personList = null;
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
