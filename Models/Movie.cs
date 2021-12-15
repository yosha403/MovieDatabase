using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Romance
    }
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }
        public Genre Genre { get; set; }

        [Range(1880,2021)]
        public int Year { get; set; }
        public int Runtime { get; set; }
    }
}
