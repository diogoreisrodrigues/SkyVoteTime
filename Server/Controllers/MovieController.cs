using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Service;
using SkyVoteTime.Server.Models;


namespace SkyVoteTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController: ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        public async Task<List<Movie>> GetAll()
        {
            return await _movieService.GetAllMovies();
        }
        [HttpGet("{id}")]
        public async Task<Movie> Get(int id)
        {
            return await _movieService.GetMovie(id);
        }
        [HttpPost]
        public async Task<Movie> AddMovie([FromBody] Movie movie)
        {
            return await _movieService.AddMovie(movie);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteMovie(int id)
        {
            await _movieService.DeleteMovie(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdateMovie(int id, [FromBody] Movie Object)
        {
            await _movieService.UpdateMovie(id, Object);
            return true;
        }
    }
}
