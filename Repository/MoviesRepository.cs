using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Models;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MovieContext _context;
        private readonly IGenresService _genresService;
        private readonly IPeopleService _peopleService;

        public MoviesRepository(MovieContext context, IGenresService genresService, IPeopleService peopleService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _genresService = genresService ?? throw new ArgumentNullException(nameof(genresService));
            _peopleService = peopleService ?? throw new ArgumentNullException(nameof(peopleService));
        }

        public async void CreateMovie(MovieViewModel movieModel)
        {
            var movie = MapMovie(movieModel);

            await _context.AddAsync(movie);
            await _context.SaveChangesAsync();

        }

        public async void EditMovie(int id, MovieViewModel movieModel)
        {
            var movie = MapMovie(movieModel);

            _context.RemoveRange(_context.MovieCasts.Where(x => x.MovieID == id));
            _context.RemoveRange(_context.MovieGenres.Where(x => x.MovieID == id));
            await _context.SaveChangesAsync();

            _context.AddRange(GetNewMovieCast(id, movieModel.SelectedDirectorsID, movieModel.SelectedWritersID, movieModel.SelectedActorsID));
            _context.AddRange(GetNewMovieGenres(id, movieModel.SelectedGenresID));
            _context.Update(movie);

            await _context.SaveChangesAsync();
        }

        public void RemoveMovie(Movie movie)
        {
            _context.Movie.Remove(movie);
            _context.SaveChanges();
        }

        public Movie FindMovieById(int? id)
        {
            return _context.Movie.Find(id);
        }

        public bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }

        #region Get new MoviCast/MovieGenrs
        private List<MovieCast> GetNewMovieCast(int id, List<int> directors, List<int> writers, List<int> actors)
        {
            var movieCastList = new List<MovieCast>();

            foreach (var item in directors)
                movieCastList.Add(new MovieCast { MovieID = id, MovieRoleID = 1, PersonID = item });

            foreach (var item in writers)
                movieCastList.Add(new MovieCast { MovieID = id, MovieRoleID = 2, PersonID = item });

            foreach (var item in actors)
                movieCastList.Add(new MovieCast { MovieID = id, MovieRoleID = 3, PersonID = item });

            return movieCastList;
        }
        private List<MovieGenres> GetNewMovieGenres(int id, List<int> genres)
        {
            var movieGenresList = new List<MovieGenres>();

            foreach (var item in genres)
                movieGenresList.Add(new MovieGenres { MovieID = id, GenreID = item });

            return movieGenresList;
        }
        #endregion

        #region Get Edited/Details MovieViewModel
        public MovieViewModel GetMovieViewModelEdited(Movie movie)
        {
            var movieModel = MapMovieViewModel(movie);

            movieModel.ID = movie.ID;
            movieModel.Genres = _genresService.GetSelectListGenres();
            movieModel.People = _peopleService.GetSelectListPeople();

            movieModel.SelectedGenresID = _genresService.GetMovieGenresIDByMovieID(movie.ID);
            movieModel.SelectedDirectorsID = _peopleService.GetMovieCastIDByMovieID(movie.ID, 1);
            movieModel.SelectedWritersID = _peopleService.GetMovieCastIDByMovieID(movie.ID, 2);
            movieModel.SelectedActorsID = _peopleService.GetMovieCastIDByMovieID(movie.ID, 3);

            return movieModel;
        }

        public MovieViewModel GetMovieViewModelDetails(Movie movie)
        {
            var movieModel = MapMovieViewModel(movie);

            movieModel.ID = movie.ID;

            movieModel.SelectedGenres = _genresService.GetMovieGenresNamesByMovieID(movie.ID);
            movieModel.SelectedDirectors = _peopleService.GetMovieCastNamesByMovieID(movie.ID, 1);
            movieModel.SelectedWriters = _peopleService.GetMovieCastNamesByMovieID(movie.ID, 2);
            movieModel.SelectedActors = _peopleService.GetMovieCastNamesByMovieID(movie.ID, 3);

            return movieModel;
        }

        private MovieViewModel MapMovieViewModel(Movie movie)
        {
            var movieModel = new MovieViewModel();
            movieModel.MovieTitle = movie.MovieTitle;
            movieModel.Summary = movie.Summary;
            movieModel.ReleaseDate = movie.ReleaseDate;
            movieModel.Runtime = movie.Runtime;
            movieModel.MovieRating = movie.MovieRating;
            movieModel.MoviePrice = movie.MoviePrice;
            movieModel.IMDBLink = movie.IMDBLink;
            movieModel.MoviePosterURL = movie.MoviePosterURL;
            return movieModel;
        }
        #endregion

        #region Get Maped Movie
        private Movie MapMovie(MovieViewModel movieModel)
        {
            var movie = new Movie();
            var genreList = new List<MovieGenres>();
            var castList = new List<MovieCast>();

            if (movieModel.ID != 0)
            {
                movie.ID = movieModel.ID;
            }
            else
            {
                foreach (var item in movieModel.SelectedGenresID)
                {
                    genreList.Add(new MovieGenres { GenreID = item });
                }
                foreach (var item in movieModel.SelectedDirectorsID)
                {
                    castList.Add(new MovieCast { PersonID = item, MovieRoleID = 1 });
                }
                foreach (var item in movieModel.SelectedWritersID)
                {
                    castList.Add(new MovieCast { PersonID = item, MovieRoleID = 2 });
                }
                foreach (var item in movieModel.SelectedActorsID)
                {
                    castList.Add(new MovieCast { PersonID = item, MovieRoleID = 3 });
                }
                movie.MovieGenres = genreList;
                movie.MovieCastList = castList;
            }

            movie.MovieTitle = movieModel.MovieTitle;
            movie.Summary = movieModel.Summary;
            movie.ReleaseDate = movieModel.ReleaseDate;
            movie.Runtime = movieModel.Runtime;
            movie.MovieRating = movieModel.MovieRating;
            movie.MoviePrice = movieModel.MoviePrice;
            movie.IMDBLink = movieModel.IMDBLink;
            movie.MoviePosterURL = movieModel.MoviePosterURL;

            return movie;
        }
        #endregion

    }
}
