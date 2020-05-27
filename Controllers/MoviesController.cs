using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Models;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MovieWeb.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;
        private readonly IGenresService _genresService;
        private readonly IPeopleService _peopleService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(
            IMoviesService moviesService,
            IGenresService genresService,
            IPeopleService peopleService,
            ILogger<MoviesController> logger
            )
        {
            _moviesService = moviesService ?? throw new ArgumentNullException(nameof(moviesService));
            _genresService = genresService ?? throw new ArgumentNullException(nameof(genresService));
            _peopleService = peopleService ?? throw new ArgumentNullException(nameof(peopleService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }



        // GET: Movies
        public IActionResult Index()
        {
            return View();
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            var movieModel = new MovieViewModel()
            {
                Genres = _genresService.GetSelectListGenres(),
                People = _peopleService.GetSelectListPeople()
            };
            return View(movieModel);
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel movieModel)
        {

            if (ModelState.IsValid)
            {
                _moviesService.CreateMovie(movieModel);
                return RedirectToAction(nameof(Index));
            }
            return View(movieModel);
        }


        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _moviesService.FindMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var movieModel = _moviesService.GetMovieViewModelDetails(movie);
            return View(movieModel);
        }

        // GET: Movies/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _moviesService.FindMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var movieModel = _moviesService.GetMovieViewModelEdited(movie);
            return View(movieModel);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, MovieViewModel movieModel)
        {
            if (id != movieModel.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _moviesService.EditMovie(id, movieModel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_moviesService.MovieExists(movieModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(movieModel);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _moviesService.FindMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var movieModel = _moviesService.GetMovieViewModelDetails(movie);
            return View(movieModel);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _moviesService.FindMovieById(id);

            _moviesService.RemoveMovie(movie);

            return RedirectToAction(nameof(Index));
        }



        #region UploadPhoto
        [HttpPost]
        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = fileName;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        #endregion

    }
}
