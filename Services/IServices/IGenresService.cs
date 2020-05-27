using Microsoft.AspNetCore.Mvc.Rendering;
using MovieWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services.IServices
{
    public interface IGenresService
    {
        List<Genre> GetAllGenres();

        List<SelectListItem> GetSelectListGenres();

        List<int> GetMovieGenresIDByMovieID(int? id);

        List<string> GetMovieGenresNamesByMovieID(int? id);
        Genre GetGenreById(int? id);
        void CreateGenre(Genre genre);
        void EditGenre(Genre genre);
        void DeleteGenre(Genre genre);
        bool GenreExists(int id);
    }
}
