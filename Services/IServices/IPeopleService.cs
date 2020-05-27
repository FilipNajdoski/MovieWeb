using Microsoft.AspNetCore.Mvc.Rendering;
using MovieWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Services.IServices
{
    public interface IPeopleService
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int? id);
        void CreatePerson(Person person);
        void EditPerson(Person person);
        void DeletePerson(Person person);
        bool PersonExists(int id);

        List<SelectListItem> GetSelectListPeople();

        List<int> GetMovieCastIDByMovieID(int? id, int roleId);

        List<string> GetMovieCastNamesByMovieID(int? id, int roleId);

        List<PersonDTO> GetMoviePersonDTOByMovieID(int? id, int roleId);
    }
}
