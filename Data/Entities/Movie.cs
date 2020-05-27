using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWeb.Data.Entities
{
    public class Movie
    {

        [Key]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string MovieTitle { get; set; }

        [StringLength(1000)]
        public string Summary { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public double MovieRating { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double MoviePrice { get; set; }

        [Display(Name = "IMDB Link")]
        [DataType(DataType.Url)]
        public string IMDBLink { get; internal set; }

        [StringLength(50)]
        public string MoviePosterURL { get; set; }

        public IList<MovieCast> MovieCastList { get; set; }
        public IList<MovieGenres> MovieGenres { get; set; }

    }

    public class MovieDTO
    {
        public int ID { get; set; }
        public string MovieTitle { get; set; }

        public string Summary { get; set; }

        public DateTime? ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public double MovieRating { get; set; }

        public double MoviePrice { get; set; }

        public string IMDBLink { get; internal set; }

        public string MoviePosterURL { get; set; }

        public List<string> Genres { get; set; }
        public List<PersonDTO> Directors { get; set; }
        public List<PersonDTO> Writers { get; set; }
        public List<PersonDTO> Actors { get; set; }
    }
}
