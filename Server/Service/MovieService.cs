﻿using SkyVoteTime.Server.Repository;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public class MovieService: IMovieService
    {
        private readonly IRepository<Movie> _movie;
        public MovieService(IRepository<Movie> movie)
        {
            _movie = movie;
        }
        public async Task<Movie> AddMovie(Movie movie)
        {
            return await _movie.CreateAsync(movie);
        }
        public async Task<bool> UpdateMovie(int id, Movie movie)
        {
            var data = await _movie.GetByIdAsync(id);
            if (data != null)
            {
                data.title = movie.title;
                data.Id = movie.Id;
                data.poster_path = movie.poster_path;
                data.overview = movie.overview;
                return true;
            }
            else
                return false;
        }
        public async Task<bool> DeleteMovie(int id)
        {
            await _movie.DeleteAsync(id);
            return true;
        }
        public async Task<List<Movie>> GetAllMovies()
        {
            return await _movie.GetAllAsync();
        }
        public async Task<Movie> GetMovie(int id)
        {
            return await _movie.GetByIdAsync(id);
        }
    }
}