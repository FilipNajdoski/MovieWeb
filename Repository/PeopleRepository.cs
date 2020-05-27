using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;
using MovieWeb.Data.Entities;
using MovieWeb.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly MovieContext _context;

        public PeopleRepository(MovieContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Person> GetAllPeople()
        {
            return _context.Person.ToList();
        }

        public Person GetPersonById(int? id)
        {
            return _context.Person.FirstOrDefault(x => x.PersonID == id);
        }
        public void CreatePerson (Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();               
        }
        public void EditPerson(Person person)
        {
            _context.Person.Update(person);
            _context.SaveChanges();
        }
        public void DeletePerson(Person person)
        {
            _context.Person.Remove(person);
            _context.SaveChanges();
        }
        public bool PersonExists (int id)
        {
            var result = _context.Person.Any(e => e.PersonID == id);
            return result;
        }

        public List<int> GetMovieCastIDByMovieID(int? id, int roleId)
        {
            var cast = _context.Person
           .Where(x => x.MovieCast.Any(y => y.MovieID == id))
           .Where(x => x.MovieCast.Any(y => y.MovieRoleID == roleId))
           .Select(x => x.PersonID)
           .ToList();
            return cast;
        }

        public List<string> GetMovieCastNamesByMovieID(int? id, int roleId)
        {
            var cast = _context.Person
           .Where(x => x.MovieCast.Any(y => y.MovieID == id))
           .Where(x => x.MovieCast.Any(y => y.MovieRoleID == roleId))
           .Select(x => x.PersonName)
           .ToList();
            return cast;
        }

        public List<PersonDTO> GetMoviePersonDTOByMovieID(int? id, int roleId)
        {
            var list =
                _context.Person
                .Where(x => x.MovieCast.Any(b => b.MovieID == id))
                .Where(x => x.MovieCast.Any(b => b.MovieRoleID == roleId))
                .Select(x => new PersonDTO { PersonID = x.PersonID, PersonName = x.PersonName })
                .ToList();
            return list;
        }

        public List<SelectListItem> GetSelectListPeople()
        {
            var people = GetAllPeople();
            var list = new List<SelectListItem>();
            foreach (var item in people)
            {
                list.Add(new SelectListItem
                {
                    Value = item.PersonID.ToString(),
                    Text = item.PersonName,
                });
            }
            return list;
        }
    }
}
