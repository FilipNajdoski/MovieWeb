using MovieWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services.IServices
{
    public interface IMoviesApiService
    {
        List<MovieDTO> GetAllMoviesApi();

        List<MovieDTO> GetTopMoviesApi(int number);

        MovieDTO GetMovieByIdApi(int id);

        List<MovieDTO> SearchMoviesApi(string search);
    }
}
