﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie name.")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select release date.")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage = "Number in stock should be in 1 to 20.")]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please select genre.")]
        public int GenreId { get; set; }
    }
}