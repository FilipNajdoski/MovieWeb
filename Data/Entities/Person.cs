using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Data.Entities
{
    public class Person
    {

        [Key]
        public int PersonID { get; set; }

        [Display(Name = "Person Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string PersonName { get; set; }

        [StringLength(1000)]
        public string Biography { get; set; }

        [StringLength(10, MinimumLength = 5)]
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Place Of Birth")]
        [StringLength(200)]
        public string PlaceOfBirth { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Date Of Death")]
        [DataType(DataType.Date)]
        public DateTime? DateOfDeath { get; set; }

        [Display(Name = "IMDB Link")]
        [DataType(DataType.Url)]
        public string IMDBPersonLink { get; internal set; }

        public IList<MovieCast> MovieCast { get; set; }
    }

    public class PersonDTO
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
    }
}
