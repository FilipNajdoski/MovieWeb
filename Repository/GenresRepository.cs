using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Repository.IRepository;
using MovieWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Repository
{
    public class GenresRepository : IGenresRepository
    {
        private readonly MovieContext _context;

        public GenresRepository(MovieContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genre.ToList();
        }
        public Genre GetGenreById(int? id)
        {
            var result = _context.Genre.FirstOrDefault(x => x.GenreID == id);
            return result;
        }
        public void CreateGenre (Genre genre)
        {
            _context.Add(genre);
            _context.SaveChanges();
        }

        public void EditGenre(Genre genre)
        {
            _context.Update(genre);
            _context.SaveChanges();
        }
        public void DeleteGenre(Genre genre)
        {
            _context.Remove(genre);
            _context.SaveChanges();
        }
        public bool GenreExists(int id)
        {
            var result = _context.Genre.Any(x => x.GenreID == id);
            return result;
        }

        public List<int> GetMovieGenresIDByMovieID(int? id)
        {
            var genres = _context.Genre
                 .Where(x => x.MovieGenres.Any(y => y.MovieID == id))
                 .Select(x => x.GenreID)
                 .ToList();

            return genres;
        }

        public List<string> GetMovieGenresNamesByMovieID(int? id)
        {
            var genres = _context.Genre
                 .Where(x => x.MovieGenres.Any(y => y.MovieID == id))
                 .Select(x => x.GenreName)
                 .ToList();

            return genres;
        }

        public List<SelectListItem> GetSelectListGenres()
        {
            var genres = GetAllGenres();
            var list = new List<SelectListItem>();
            foreach (var item in genres)
            {
                list.Add(new SelectListItem
                {
                    Value = item.GenreID.ToString(),
                    Text = item.GenreName
                });
            }
            return list;
        }        
    }
}
