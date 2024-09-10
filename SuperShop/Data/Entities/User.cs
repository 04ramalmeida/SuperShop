﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SuperShop.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(50, ErrorMessage = "The field {0} can only contain {1} characters length.")]
        public string FirstName { get; set; }
        
        [MaxLength(50, ErrorMessage = "The field {0} can only contain {1} characters length.")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The field {0} can only contain {1} characters length.")]
        public string Address { get; set; }

        public int CityID { get; set; }
        
        public City City { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
