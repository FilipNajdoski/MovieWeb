using MovieWeb.Data.Entities;
using MovieWeb.Models;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;

        public MoviesService(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository ?? throw new ArgumentNullException(nameof(moviesRepository));
        }

        public void CreateMovie(MovieViewModel movieModel)
        {
            _moviesRepository.CreateMovie(movieModel);
        }

        public void EditMovie(int id, MovieViewModel movieModel)
        {
            _moviesRepository.EditMovie(id, movieModel);
        }

        public void RemoveMovie(Movie movie)
        {
            _moviesRepository.RemoveMovie(movie);
        }
        public bool MovieExists(int id)
        {
            return _moviesRepository.MovieExists(id);
        }

        public Movie FindMovieById(int? id)
        {
            return _moviesRepository.FindMovieById(id);
        }

        public MovieViewModel GetMovieViewModelEdited(Movie movie)
        {
            return _moviesRepository.GetMovieViewModelEdited(movie);
        }

        public MovieViewModel GetMovieViewModelDetails(Movie movie)
        {
            return _moviesRepository.GetMovieViewModelDetails(movie);
        }
    }
}
