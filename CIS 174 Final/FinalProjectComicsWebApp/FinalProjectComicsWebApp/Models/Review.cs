using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectComicsWebApp.Models
{
    //review class, holds reviewid, userid, user, comicid, comic, rating, and review content
    public class Review
    {
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "Please enter a user id")]
        public int UserId { get; set; }
        public User User { get; set; }

        public int ComicId { get; set; }
        public Comic Comic { get; set; }

        [Required(ErrorMessage = "Please enter a rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a review")]
        public string ReviewContent { get; set; }
    }
}
