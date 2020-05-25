using MovieBuzz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBuzz.ViewModel
{
    public class MoviesViewModel
    {
        public IEnumerable<Genre>  Genres { get; set; }

        public int? id { get; set; }

        [Required]
        [Display(Name = "Movie Name")]
        public string movieName { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? AddedDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Numbers in Stock")]
        public int? NumbersInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public short GenreId { get; set; }

        public string Title
        {
            get
            {
                if (id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }


        public MoviesViewModel()
        {
            id = 0;
        }

        public MoviesViewModel(Movies movies)
        {
            id = movies.id;
            movieName = movies.movieName;
            ReleaseDate = movies.ReleaseDate;
            AddedDate = movies.AddedDate;
            GenreId = movies.GenreId;
            NumbersInStock = movies.NumbersInStock;
        }
    }
}