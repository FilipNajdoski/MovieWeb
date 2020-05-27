using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Repository
{
    public class MoviesApiRepository : IMoviesApiRepository
    {
        private readonly MovieContext _context;
        private readonly IGenresService _genresService;
        private readonly IPeopleService _peopleService;

        public MoviesApiRepository(MovieContext context, IGenresService genresService, IPeopleService peopleService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _genresService = genresService ?? throw new ArgumentNullException(nameof(genresService));
            _peopleService = peopleService ?? throw new ArgumentNullException(nameof(peopleService));
        }

        public List<MovieDTO> GetAllMoviesApi()
        {
            var movies = _context.Movie.ToList();

            var movieDTOList = MapMovieDTOList(movies);

            return movieDTOList;
        }


        public List<MovieDTO> GetTopMoviesApi(int number)
        {
            var topMovies = _context.Movie.OrderByDescending(x => x.MovieRating).Take(number).ToList();

            var movieDTOList = MapMovieDTOList(topMovies);

            return movieDTOList;
        }


        public MovieDTO GetMovieByIdApi(int id)
        {
            var movie = _context.Movie.Find(id);

            var movieDTO = MapMovieDTO(movie);

            return movieDTO;
        }

        public List<MovieDTO> SearchMoviesApi(string search)
        {
            var searchedMovies = _context.Movie.Where(s => s.MovieTitle.Contains(search)).ToList();

            var movieDTOList = MapMovieDTOList(searchedMovies);

            return movieDTOList;
        }

        #region MapMoviDTOList
        private List<MovieDTO> MapMovieDTOList(List<Movie> movies)
        {
            var movieList = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                movieList.Add(MapMovieDTO(movie));
            }
            return movieList;
        }

        private MovieDTO MapMovieDTO(Movie movie)
        {
            var movieDTO = new MovieDTO
            {
                ID = movie.ID,
                MovieTitle = movie.MovieTitle,
                Summary = movie.Summary,
                ReleaseDate = movie.ReleaseDate,
                Runtime = movie.Runtime,
                MovieRating = movie.MovieRating,
                MoviePrice = movie.MoviePrice,
                MoviePosterURL = movie.MoviePosterURL,
                IMDBLink = movie.IMDBLink,
                Genres = _genresService.GetMovieGenresNamesByMovieID(movie.ID),
                Directors = _peopleService.GetMoviePersonDTOByMovieID(movie.ID, 1),
                Writers = _peopleService.GetMoviePersonDTOByMovieID(movie.ID, 2),
                Actors = _peopleService.GetMoviePersonDTOByMovieID(movie.ID, 3)
            };
            return movieDTO;
        }



        #endregion
    }
}

