using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Module5_Ord.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }

        //public string Slug => Name?.Replace(' ', '-').ToLower();

        public string Slug
        {
            get
            {
                if (Name == null)
                    return "";
                else
                    return Name.Replace(' ', '-');
            }
        }
    }
}
