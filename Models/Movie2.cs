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
        public int Year { get; set; }
        public string Rated { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public double imdbRating { get; set; }
        public int Metascore { get; set; }
        public string BoxOffice { get; set; }
        public string Actors { get; set; }
        public string Director {get; set;}
        public string Production { get; set; }
        public string Type { get; set; }
        public string Awards { get; set; }
        public string Language { get; set; }
        public string Plot { get; set; }
        public string Writer { get; set; }
        [DisplayFormat(DataFormatString = "{0: MMMM dd yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Released { get; set; }
        public string Country { get; set; }
    }
}
