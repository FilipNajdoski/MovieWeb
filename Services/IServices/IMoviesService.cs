using MovieWeb.Data.Entities;
using MovieWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services.IServices
{
    public interface IMoviesService
    {
        void CreateMovie(MovieViewModel movieModel);

        void EditMovie(int id, MovieViewModel movieModel);

        void RemoveMovie(Movie movie);

        Movie FindMovieById(int? id);

        bool MovieExists(int id);

        MovieViewModel GetMovieViewModelEdited(Movie movie);

        MovieViewModel GetMovieViewModelDetails(Movie movie);
    }
}
