using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppOrd.Models
{
    public class FirstResponseModel
    {
		const int DAYS_IN_YEAR = 365;  // Constant to hold number of days in 1 year
		const int ONE_YEAR = 1;        // Constant to hold 1 year
		[Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please select a date for your birthday.")]
        [DataType(DataType.DateTime)]
        public DateTime BirthYear { get; set; }

        // Validation for BirthYear is on the label within the form
        public int AgeThisYear()  // Function to calculate current age
        {
            int age = DateTime.Now.Subtract(BirthYear).Days;
            age = age / DAYS_IN_YEAR;
            return age;  // Returns current age
        }

        public int AgeByEndOfYear() // Function to calculate age by the end of the year
        {
            int age = DateTime.Now.Subtract(BirthYear).Days;

            age = age / DAYS_IN_YEAR + ONE_YEAR;
            return age; //returns future age
        }

    }
}

//        