using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie2
    {   
        [Key]
        public string imdbID { get; set; }
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
    }
}
