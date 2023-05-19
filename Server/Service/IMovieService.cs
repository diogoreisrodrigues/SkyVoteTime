using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public interface IMovieService
    {
        Task<Movie> AddMovie(Movie movie);
        Task<bool> UpdateMovie(int id, Movie movie);
        Task<bool> DeleteMovie(int id);
        Task<List<Movie>> GetAllMovies();
        Task<Movie> GetMovie(int id);
    }
}
