using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Module5_Ord.Models
{
    public class Contact
    {
        
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        public string ContactPhone { get; set; } // Setting the phone as a string so I can include '-'

        [Required(ErrorMessage = "Please enter an address")]
        public string ContactAddress { get; set; }

        public string ContactNote { get; set; }
    }
}
