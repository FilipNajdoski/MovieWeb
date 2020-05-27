using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }
        // Movie Data
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
        public double MoviePrice { get; set; }

        [Display(Name = "IMDB Link")]
        [DataType(DataType.Url)]
        public string IMDBLink { get; internal set; }

        [StringLength(50)]
        public string MoviePosterURL { get; set; }

        // Get Genres
        public List<SelectListItem> Genres { get; set; }

        // Get People
        public List<SelectListItem> People { get; set; }

        // Post Genre
        public List<int> SelectedGenresID { get; set; }
        public List<string> SelectedGenres { get; set; }

        // Post Directors
        public List<int> SelectedDirectorsID { get; set; }
        public List<string> SelectedDirectors { get; set; }

        // Post Writers
        public List<int> SelectedWritersID { get; set; }
        public List<string> SelectedWriters { get; set; }

        // Post Actors
        public List<int> SelectedActorsID { get; set; }
        public List<String> SelectedActors { get; set; }
    }
}
