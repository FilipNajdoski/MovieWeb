using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [System.Runtime.InteropServices.Guid("71F75767-06B6-4F4D-9521-20ADBCEAD6B8")]
    public class MoviesApiController : ControllerBase
    {
        private readonly MovieContext _context;
        private readonly IMoviesApiService _moviesApiService;
        private readonly ILogger<MoviesApiController> _logger;

        public MoviesApiController(
            MovieContext context,
            IMoviesApiService moviesApiService,
            ILogger<MoviesApiController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _moviesApiService = moviesApiService ?? throw new ArgumentNullException(nameof(moviesApiService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }



        // GET: api/MoviesApi
        [HttpGet]
        public ActionResult<IEnumerable<MovieDTO>> GetMovie()
        {
            var movieList = _moviesApiService.GetAllMoviesApi();

            return movieList;
        }


        // GET: api/MoviesApi/TopMovies
        [HttpGet("GetTopMovies/{number}")]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetTopMovies(int number)
        {

            var movie = _moviesApiService.GetTopMoviesApi(number);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet("{id}")]
        public ActionResult<MovieDTO> GetMovie(int id)
        {
            var movie = _moviesApiService.GetMovieByIdApi(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet("SearchMovies/{search?}")]
        public ActionResult<IEnumerable<MovieDTO>> GetMovie(string search)
        {
            if (String.IsNullOrWhiteSpace(search))
            {
                var movieList = _moviesApiService.GetAllMoviesApi();
                return movieList;
            }
            else
            {
                var movieSearched = _moviesApiService.SearchMoviesApi(search);

                if (movieSearched == null)
                {
                    return NotFound();
                }

                return movieSearched;
            }
        }

    }
}
