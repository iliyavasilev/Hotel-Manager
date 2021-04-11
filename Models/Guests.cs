using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Guests
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required, StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string EMail { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage = "You have to be 18+")]
        public bool Adult { get; set; }
    }
}