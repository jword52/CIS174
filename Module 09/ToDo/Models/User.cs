﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace ToDoApp.Models
{
    public class User
    {
        public int ID { get; set; }  // will be autogenerated by database

        [Required(ErrorMessage = "Please enter a username.")]
        [RegularExpression("(?i)^[a-z0-9 ]+$",
            ErrorMessage = "Username may not contain special characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [Remote("CheckEmail", "Validation")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Please enter a password.")]
        [Compare("ConfirmPassword")]
        [StringLength(25,
            ErrorMessage = "Please limit your password to 25 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}