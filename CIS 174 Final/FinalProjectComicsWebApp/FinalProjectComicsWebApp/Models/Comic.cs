using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectComicsWebApp.Models
{
    //comic class, holds comicid, title, rating, and reviews
    public class Comic
    {
        public int ComicId { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string? Title { get; set; }

        public double Rating { get; set; }

        public int TotalReviews { get; set; }
    }
}
