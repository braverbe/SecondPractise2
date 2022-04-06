using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondPractise2.Models
{
    public class LoginModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(length:8)]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(18, 65)]
        public int Age { get; set; }
    }
}