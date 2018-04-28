using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PojectOrderingFod.Models
{
    public class UserAddModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string PoctCode { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        public string RepeatPassword { get; set; }
    }
}
