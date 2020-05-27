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
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository ?? throw new ArgumentNullException(nameof(peopleRepository));
        }

        public void CreatePerson(Person person)
        {
            _peopleRepository.CreatePerson(person);
        }

        public void DeletePerson(Person person)
        {
            _peopleRepository.DeletePerson(person);
        }

        public void EditPerson(Person person)
        {
            _peopleRepository.EditPerson(person);
        }

        public List<Person> GetAllPeople()
        {
            return _peopleRepository.GetAllPeople();
        }

        public List<int> GetMovieCastIDByMovieID(int? id, int roleId)
        {
            return _peopleRepository.GetMovieCastIDByMovieID(id, roleId);
        }

        public List<string> GetMovieCastNamesByMovieID(int? id, int roleId)
        {
            return _peopleRepository.GetMovieCastNamesByMovieID(id, roleId);
        }

        public List<PersonDTO> GetMoviePersonDTOByMovieID(int? id, int roleId)
        {
            return _peopleRepository.GetMoviePersonDTOByMovieID(id, roleId);
        }

        public Person GetPersonById(int? id)
        {
            return _peopleRepository.GetPersonById(id);
        }

        public List<SelectListItem> GetSelectListPeople()
        {
            return _peopleRepository.GetSelectListPeople();
        }

        public bool PersonExists(int id)
        {
            return _peopleRepository.PersonExists(id);
        }
    }
}
