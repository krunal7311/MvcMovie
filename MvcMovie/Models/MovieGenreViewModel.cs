using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        //List of Movies
        public List<Movie> movies;

        //List of Genres
        public SelectList genres;

        //Selected Movie Genre
        public string movieGenre { get; set; }
    }
}
