using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBuzz.Models
{
    public class Movies
    {
        public int id { get; set; }

        [Required]
        [Display(Name ="Movie Name")]
        public string  movieName { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name ="Date Added")]
        public DateTime AddedDate { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name ="Numbers in Stock")]
        public int NumbersInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name ="Genre")]
        [Required]
        public short GenreId { get; set; }

    }
}