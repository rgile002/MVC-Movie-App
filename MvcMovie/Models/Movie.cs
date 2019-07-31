using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Please Enter a valid Title!")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        
        [Required(ErrorMessage = "Please Enter a Genre!")]
        [StringLength(30, ErrorMessage = "Please Enter a Genre with less then 30 char!")]
        public string Genre { get; set; }

        [Range(1, 100, ErrorMessage = "Please Enter a price between 1 and 100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9_-]*$", ErrorMessage = "Please Enter a valid Rating!")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBCOntext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}