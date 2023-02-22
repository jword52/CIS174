using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Module5_Ord.Areas.Admin.Models
 
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Please enter a note.")]
        public string? Note { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}