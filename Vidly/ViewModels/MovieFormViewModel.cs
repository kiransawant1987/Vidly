using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
        }

        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";
            }
        }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter movie name.")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Release date is required.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage = "Number in stock should be in 1 to 20.")]
        public int? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select genre.")]
        public int? GenreId { get; set; }

        public List<Genre> Genres { get; set; }
    }
}