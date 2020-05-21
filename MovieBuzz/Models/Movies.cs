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
        public string  movieName { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public int NumbersInStock { get; set; }

        public Genre Genre { get; set; }

        public short GenreId { get; set; }

    }
}