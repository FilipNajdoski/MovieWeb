using Microsoft.AspNetCore.Mvc.Rendering;
using MovieWeb.Data.Entities;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services
{
    public class GenresService : IGenresService
    {
        private readonly IGenresRepository _genresRepository;

        public GenresService(IGenresRepository genresRepository)
        {
            this._genresRepository = genresRepository ?? throw new ArgumentNullException(nameof(genresRepository));
        }

        public void CreateGenre(Genre genre)
        {
            _genresRepository.CreateGenre(genre);
        }

        public void DeleteGenre(Genre genre)
        {
            _genresRepository.DeleteGenre(genre);
        }

        public void EditGenre(Genre genre)
        {
            _genresRepository.EditGenre(genre);
        }

        public bool GenreExists(int id)
        {
            return _genresRepository.GenreExists(id);
        }

        public List<Genre> GetAllGenres()
        {
            return _genresRepository.GetAllGenres();
        }

        public Genre GetGenreById(int? id)
        {
            return _genresRepository.GetGenreById(id);
        }


        public List<int> GetMovieGenresIDByMovieID(int? id)
        {
            return _genresRepository.GetMovieGenresIDByMovieID(id);
        }

        public List<string> GetMovieGenresNamesByMovieID(int? id)
        {
            return _genresRepository.GetMovieGenresNamesByMovieID(id);
        }

        public List<SelectListItem> GetSelectListGenres()
        {
            return _genresRepository.GetSelectListGenres();
        }
    }
}
