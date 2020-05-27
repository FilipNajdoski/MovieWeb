using MovieWeb.Data.Entities;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace MovieWeb.Services
{
    public class MoviesApiService : IMoviesApiService
    {
        private readonly IMoviesApiRepository _moviesApiRepository;

        public MoviesApiService(IMoviesApiRepository moviesApiRepository)
        {
            _moviesApiRepository = moviesApiRepository ?? throw new ArgumentNullException(nameof(moviesApiRepository));
        }

        public List<MovieDTO> GetAllMoviesApi()
        {
            return _moviesApiRepository.GetAllMoviesApi();
        }

        public MovieDTO GetMovieByIdApi(int id)
        {
            return _moviesApiRepository.GetMovieByIdApi(id);
        }

        public List<MovieDTO> GetTopMoviesApi(int number)
        {
            return _moviesApiRepository.GetTopMoviesApi(number);
        }

        public List<MovieDTO> SearchMoviesApi(string search)
        {
            return _moviesApiRepository.SearchMoviesApi(search);
        }
    }
}
