using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Data.Entities
{
    public class Genre
    {

        [Key]
        public int GenreID { get; set; }

        [Display(Name = "Genre Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string GenreName { get; set; }

        public IList<MovieGenres> MovieGenres { get; set; }

    }
}